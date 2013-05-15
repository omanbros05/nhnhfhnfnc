using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    public partial class InstrumentsHistoryFile
    {
        public InstrumentsHistoryFolder Folder = new InstrumentsHistoryFolder();
        public int ParentType = -1;
        public int ChildType = -1;
        protected override void BeginUpdate(System.Data.Common.DbTransaction trans)
        {
            base.BeginUpdate(trans);
            EList<InstrumentsHistoryFile> Files = this.InstrumentsHistoryFileGetAll(1,20,"","",this.TableName,this.TableID);
            if (Files.Items.Count <= 0)
            {
                EList<InstrumentsHistoryFolder> Objs = Folder.InstrumentsHistoryFolderGetAll(1, 20, this.ParentType, this.ChildType, DateTime.Now.Year, DateTime.Now.Month);
                if (Objs.Items.Count <= 0)
                {
                    Folder.InstrumentsChildType = ChildType;
                    Folder.InstrumentsParentType = ParentType;
                    Folder.InstrumentsYear = DateTime.Now.Year;
                    Folder.InstrumentsMonth = DateTime.Now.Month;
                    Folder.SQLtransaction = this.SQLtransaction;
                    Folder.SystemService = this.SystemService;
                    Folder.Update();
                    this.InstrumentsFolderID = Folder.ID;
                }
                else
                {
                    this.InstrumentsFolderID = Objs.Items[0].ID;
                }
            }
            else
            {
                return;
            }

        }

        /// <summary>
        /// 历史文书文件集合
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="Title">标题</param>
        /// <param name="CompanyName">当事人</param>
        /// <param name="TabelName">所属表名</param>
        /// <param name="TableID">所属表中的ID</param>
        /// <returns></returns>
        internal EList<InstrumentsHistoryFile> InstrumentsHistoryFileGetAll(int page, int pageSize, string Title,string CompanyName,string TabelName,int TableID)
        {
            EList<InstrumentsHistoryFile> InstrumentsHistoryFiles = new EList<InstrumentsHistoryFile>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (Title != "")
            {
                Clips.Add(DataBases.InstrumentsHistoryFile.InstrumentsTitle.Like("%" + Title + "%"));
            }
            if (CompanyName != "")
            {
                Clips.Add(DataBases.InstrumentsHistoryFile.CompanyName.Like("%" + CompanyName + "%"));
            }
            if (TabelName != "")
            {
                Clips.Add(DataBases.InstrumentsHistoryFile.TableName == TableName);
            }
            if (TableID >= 0)
            {
                Clips.Add(DataBases.InstrumentsHistoryFile.TableID == TableID);
            }
            SelectSqlSection section = DB.Select(DataBases.InstrumentsHistoryFile, DataBases.InstrumentsHistoryFile.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            InstrumentsHistoryFiles.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.InstrumentsHistoryFile);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.InstrumentsHistoryFile.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        InstrumentsHistoryFile InstrumentsHistoryFile = ReadRow(reader);
                        InstrumentsHistoryFiles.Items.Add(InstrumentsHistoryFile);
                    }
                }
            }

            return InstrumentsHistoryFiles;
        }

    }
}
