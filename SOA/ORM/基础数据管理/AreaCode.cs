using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    [Synchro]
    public partial class AreaCode
    {
        internal void TransactionTest()
        {

        }

        public override string SearchColumn()
        {
            return CodeName;
        }

        protected override void BeginUpdate(DbTransaction trans)
        {
            base.BeginUpdate(trans);

            //AreaCode databaseAreaCode = null;
            //using (IDataReader reader = DB.Select(DataBases.AreaCode).Where(DataBases.AreaCode.CodeName == CodeName).SetTransaction(trans).ToDataReader())
            //{
            //    if (reader.Read())
            //    {
            //        databaseAreaCode = ReadRow(reader);
            //    }
            //}

            //if (databaseAreaCode != null)
            //{
            //    if (this.CodeID != "")
            //        databaseAreaCode.CodeID = this.CodeID;

            //    if(this.CodeName != "")
            //        databaseAreaCode.CodeName = this.CodeName;

            //    databaseAreaCode.SystemService = this.SystemService;
            //    databaseAreaCode.SQLtransaction = this.SQLtransaction;
            //    databaseAreaCode.CallBegin = false;
            //    databaseAreaCode.Update();
            //    CallUpdate = false;
            //    CallEnd = false;
            //    return;
            //}
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<AreaCode>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }

        /// <summary>
        /// 获取行政区域代码集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="code">代码</param>
        /// <param name="name">地域名称</param>
        /// <returns>实体集合</returns>
        internal EList<AreaCode> AreaCodeGetAll(int page, int pageSize, string code, string name)
        {
            EList<AreaCode> AreaCodes = new EList<AreaCode>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (code != "")
                Clips.Add(DataBases.AreaCode.CodeID.Like("%" + code + "%"));

            if (name != "")
                Clips.Add(DataBases.AreaCode.CodeName.Like("%" + name + "%"));
            SelectSqlSection section = DB.Select(DataBases.AreaCode, DataBases.AreaCode.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            AreaCodes.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.AreaCode);
                if (Clips.Count > 0)
                    section.Where(Clips);
                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.AreaCode.ID);
                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        AreaCode areaCode = ReadRow(reader);
                        AreaCodes.Items.Add(areaCode);
                    }
                }
            }

            return AreaCodes;
        }

        internal int MaxOrderId(int ParentID = 0)
        {
            SelectSqlSection section = DB.Select(DataBases.AreaCode, DataBases.AreaCode.OrderID);
            section.Where(DataBases.AreaCode.ParentID == ParentID);
            section.OrderBy(DataBases.AreaCode.OrderID.Desc);
            DataTable table = section.ToDataSet().Tables[0];
            if (table.Rows.Count > 0)
                return (int)table.Rows[0][0];
            return 0;
        }


        /// <summary>
        /// 栏目上移下移
        /// </summary>
        /// <param name="Id">移动栏目编号</param>
        /// <param name="IfUp">是否上移</param>
        /// <param name="Value">移动数量</param>
        internal void MoveAction(int Id, bool IfUp, int Value)
        {
            using (CreateTranscation())
            {
                if (IfUp)//上移
                {
                    for (int i = 0; i < Value; i++)
                    {
                        //AreaCode areaCode = (AreaCode)SystemService.EntityInit(new AreaCode { ID == Id });

                        SelectSqlSection section = DB.Select(DataBases.AreaCode);
                        section.Where(DataBases.AreaCode.ID == Id);
                        AreaCode areaCode = new AreaCode();
                        using (IDataReader reader = section.ToDataReader())
                        {
                            while (reader.Read())
                            {
                                areaCode = ReadRow(reader);
                                break;
                            }
                        }
                        if (areaCode == null)
                            break;

                        SelectSqlSection section1 = DB.Select(DataBases.AreaCode);
                        section1.Where(DataBases.AreaCode.ParentID == areaCode.ParentID &&
                            DataBases.AreaCode.OrderID < areaCode.OrderID);
                        section1.OrderBy(DataBases.AreaCode.OrderID.Desc);
                        AreaCode areaCode1 = new AreaCode();
                        using (IDataReader reader = section1.ToDataReader())
                        {
                            while (reader.Read())
                            {
                                areaCode1 = ReadRow(reader);
                                break;
                            }
                        }
                        if (areaCode1 == null)
                            break;

                        //AreaCode ac= DB.Select(DataBases.AreaCode).Where(DataBases.AreaCode.ParentID == areaCode.ParentID &&
                        //    DataBases.AreaCode.OrderID < areaCode.OrderID).OrderBy(DataBases.AreaCode.OrderID.Desc)
                        //    .;

                        DB.Update(DataBases.AreaCode).AddColumn(DataBases.AreaCode.OrderID, areaCode.OrderID)
                            .Where(DataBases.AreaCode.OrderID == areaCode1.ParentID &&
                            DataBases.AreaCode.ParentID == areaCode.ParentID).Execute();

                        areaCode.OrderID = areaCode1.OrderID;
                        areaCode.Update();
                    }
                }
                else//下移
                {
                    for (int i = 0; i < Value; i++)
                    {
                        SelectSqlSection section = DB.Select(DataBases.AreaCode);
                        section.Where(DataBases.AreaCode.ID == Id);
                        AreaCode areaCode = new AreaCode();
                        using (IDataReader reader = section.ToDataReader())
                        {
                            while (reader.Read())
                            {
                                areaCode = ReadRow(reader);
                                break;
                            }
                        }
                        if (areaCode == null)
                            break;
                        SelectSqlSection section1 = DB.Select(DataBases.AreaCode);
                        section1.Where(DataBases.AreaCode.ParentID == areaCode.ParentID &&
                            DataBases.AreaCode.OrderID > areaCode.OrderID);
                        section1.OrderBy(DataBases.AreaCode.OrderID.Desc);
                        AreaCode areaCode1 = new AreaCode();
                        using (IDataReader reader = section1.ToDataReader())
                        {
                            while (reader.Read())
                            {
                                areaCode1 = ReadRow(reader);
                                break;
                            }
                        }
                        if (areaCode1 == null)
                            break;
                        SelectSqlSection updtion1 = DB.Select(DataBases.AreaCode);
                        updtion1.Where(DataBases.AreaCode.OrderID == areaCode1.ParentID &&
                            DataBases.AreaCode.ParentID == areaCode.ParentID);
                        AreaCode areaCodeUp1 = new AreaCode();
                        using (IDataReader reader = updtion1.ToDataReader())
                        {
                            while (reader.Read())
                            {
                                areaCodeUp1 = ReadRow(reader);
                                break;
                            }
                        }
                        areaCodeUp1.OrderID = areaCode.OrderID;
                        areaCodeUp1.Update();

                        areaCode.OrderID = areaCode1.OrderID;
                        areaCode.Update();
                    }
                }
                SQLtransaction.Complete();
            }
        }
    }
}
