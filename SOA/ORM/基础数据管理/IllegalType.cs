using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    [Synchro]
    public partial class IllegalType
    {
        public override string SearchColumn()
        {
            return TypeName;
        }

        /// <summary>
        /// 根据名称更新违法行为
        /// </summary>
        /// <param name="illegalType">违法行为对象</param>
        internal void UpdateIllegalTypeByName(IllegalType illegalType)
        {
            IllegalType databaseIllegalType = null;
            using (IDataReader reader = DB.Select(DataBases.IllegalType).Where(DataBases.IllegalType.TypeName == illegalType.TypeName).ToDataReader())
            {
                if (reader.Read())
                {
                    databaseIllegalType = ReadRow(reader);
                }
            }

            if (databaseIllegalType != null)
            {
                if (illegalType.TypeName != "")
                    databaseIllegalType.TypeName = illegalType.TypeName;
                databaseIllegalType.SystemService = this.SystemService;
                databaseIllegalType.SQLtransaction = this.SQLtransaction;
                databaseIllegalType.Update();
            }
            else
            {
                illegalType.SystemService = this.SystemService;
                illegalType.SQLtransaction = this.SQLtransaction;
                illegalType.Update();
            }
        }

        /// <summary>
        /// 获取违法行为分类集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">名称</param>
        /// <returns>实体集合</returns>
        internal EList<IllegalType> IllegalTypeGetAll(int page, int pageSize, string TypeName)
        {
            EList<IllegalType> IllegalTypes = new EList<IllegalType>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (TypeName != "")
                Clips.Add(DataBases.IllegalType.TypeName.Like("%" + TypeName + "%"));

            SelectSqlSection section = DB.Select(DataBases.IllegalType, DataBases.IllegalType.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            IllegalTypes.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.IllegalType);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.IllegalType.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        IllegalType illegalType = ReadRow(reader);
                        IllegalTypes.Items.Add(illegalType);
                    }
                }
            }

            return IllegalTypes;
        }

        protected override void EndUpdate(DbTransaction trans)
        {
            base.EndUpdate(trans);

            SearchWord searchWord = SearchWord.ToSearchWord<IllegalType>(this);
            searchWord.TableID = ID.ToString();
            searchWord.SQLtransaction = this.SQLtransaction;
            searchWord.SystemService = this.SystemService;
            searchWord.Update();
        }
    }
}
