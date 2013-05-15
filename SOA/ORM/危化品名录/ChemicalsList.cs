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
    public partial class ChemicalsList
    {
        public enum EChemicalsType
        {
            爆炸品 =0,
            压缩气体和液化气体,
            易燃液体,
            易燃固体,//易燃固体、自燃物品和遇湿易燃物品
            氧化剂和有机过氧化物,
            毒害品和感染性物品,
            腐蚀品,
        }

        /// <summary>
        /// 爆炸品种类
        /// </summary>
        public enum EExplosivesType
        {
            具有整体爆炸危险的物质和物品 = 10,
            具有燃烧危险和较小爆炸或较小抛射危险,//具有燃烧危险和较小爆炸或较小抛射危险，或两者肩有、但无整体爆炸危险的物质和物品
            无重大危险的爆炸物质和物品,
        }

        /// <summary>
        /// 压缩气体和液化气体种类
        /// </summary>
        public enum EGasType
        {
            易燃气体 = 20,
            不燃气体,
            有毒气体,
        }
        /// <summary>
        /// 易燃液体种类
        /// </summary>
        public enum ECombustibleLiquidType
        {
            低闪点液体=30,
            中闪点液体,
            高闪点液体,
        }
        /// <summary>
        /// 易燃固体、自燃物品和遇湿易燃物品种类
        /// </summary>
        public enum ECombustibleSolidType
        {
            易燃固体 = 40,
            自燃物品,
            遇湿易燃物品,
        }
        /// <summary>
        /// 氧化剂和有机过氧化物种类
        /// </summary>
        public enum EOxidantType
        {
            氧化剂 = 50,
            有机过氧化物
        }
        /// <summary>
        /// 毒害品和感染性物品种类
        /// </summary>
        public enum EToxicType
        {
            毒害品=60,
        }
        /// <summary>
        /// 腐蚀品种类
        /// </summary>
        public enum ECorrosiveType
        {
            酸性腐蚀品 =70,
            碱性腐蚀品,
            其他腐蚀品
        }
        /// <summary>
        /// 危化品名录
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="Number">编号</param>
        /// <param name="Name">名称</param>
        /// <param name="Type">类别</param>
        /// <param name="ChildType">分类</param>
        /// <returns>实体集合</returns>
        internal EList<ChemicalsList> ChemicalsListGetAll(int page, int pageSize, string Number, string Name, string alias, int Type,int ChildType,string UN)
        {
            EList<ChemicalsList> ForceMeasureDecisions = new EList<ChemicalsList>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (Number != "")
            {
                Clips.Add(DataBases.ChemicalsList.ChemicalsNumber.Like("%" + Number + "%"));
            }
            if (Name != "")
            {
                Clips.Add(DataBases.ChemicalsList.ChemicalsName.Like("%" + Name + "%"));
            }

            if (! alias.Trim().Equals(string.Empty)) {
                Clips.Add(DataBases.ChemicalsList.ChemicalsAlias.Like("%" + alias + "%"));
            
            }
            if (Type >= (int)SOA.ORM.ChemicalsList.EChemicalsType.爆炸品)
            {
                Clips.Add(DataBases.ChemicalsList.ChemicalsType == Type);
            }
            if (ChildType > -1)
            {
                Clips.Add(DataBases.ChemicalsList.ChemicalsChildType == ChildType);
            }
            if (UN != "")
            {
                Clips.Add(DataBases.ChemicalsList.ChemicalsUN == UN);
            }

            SelectSqlSection section = DB.Select(DataBases.ChemicalsList, DataBases.ChemicalsList.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            ForceMeasureDecisions.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.ChemicalsList);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.ChemicalsList.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        ChemicalsList ChemicalsList = ReadRow(reader);
                        ForceMeasureDecisions.Items.Add(ChemicalsList);
                    }
                }
            }

            return ForceMeasureDecisions;
        }
    }
}
