using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using NBearLite;
using System.Data.Common;

namespace SOA.ORM
{
    public partial class InstrumentsExample
    {
        #region 文书示例类型枚举
        /// <summary>
        /// 文书示例类型
        /// </summary>
        public enum EInstrumentsType
        {
            现场检查 = 0,
            整改复查,
            简易处罚流程,
            立案调查,
            案件移送,
            查封或扣押处罚,
            处罚告知与申辩,
            听证会与呈批,
            案件处理,
            行政处罚,
            催缴与分期罚款,
            结案与延期结案,
        }
        /// <summary>
        /// 文书示例--现场检查类型
        /// </summary>
        public enum ESiteInspectionType
        { 
            现场检查记录  = 0,
            现场处理措施决定书, 
            强制措施决定审批表L15日内R,
            强制措施决定书L15日内R,
            责令限期整改指令书L30日内R,
            现场处理措施决定书L6个月内R,
        }
        /// <summary>
        /// 文书示例--整改复查类型
        /// </summary>
        public enum ERectificationReviewType
        { 
            整改复查意见书 = 10,
            复查意见审批表,
        }
        /// <summary>
        /// 文书示例--简易处罚流程类型
        /// </summary>
        public enum ESimplePunishType
        { 
            行政L当场R处罚决定书L单位R = 20,
            行政L当场R处罚决定书L个人R,
        }
        /// <summary>
        /// 文书示例--立案调查
        /// </summary>
        public enum ECaseSurveyType
        {
            立案审批表 = 30,
            询问通知书,
            询问笔录,
            勘验笔录,
            抽样取证凭证,
            鉴定委托书,
            先行登记保存证据审批表,
            先行登记保存证据通知书,
            先行登记保存证据处理审批表,
            先行登记保存证据处理决定书,
            行政处罚集体讨论记录,
            案件终止或撤销审批表,
        }
        /// <summary>
        /// 文书示例--案件移送
        /// </summary>
        public enum ECaseTransferredType
        { 
            案件移送审批表 = 50,
            案件移送书,
        }
        /// <summary>
        /// 文书示例--查封或扣押处罚
        /// </summary>
        public enum ESealPunishType
        { 
            查封或扣押决定审批表 = 60,
            查封或扣押决定书,
            查封或扣押物品清单,
            查封或扣押物品处理审批表,
            查封或扣押物品处理决定书,
        }

        /// <summary>
        /// 文书示例--处罚告知与申辩
        /// </summary>
        public enum EPunishInformDefenseType
        { 
            行政处罚告知书 = 70,
            文书送达回执,
            当事人陈诉申辩笔录,
        }
        /// <summary>
        /// 文书示例--听证会与呈批
        /// </summary>
        public enum EHearingChengpiType
        { 
            听证会通知书 = 80,
            听证笔录,
            听证会报告书,
            文书送达回执,
            询问笔录L收集相关证据R,
        }

        /// <summary>
        /// 文书示例--案件处理
        /// </summary>
        public enum ECaseHandleType
        {
            案件处理呈批表 = 90,
        }

        /// <summary>
        /// 文书示例--行政处罚
        /// </summary>
        public enum EAdminPunishType
        { 
            行政当场处罚决定书单位 =100,
            行政当场处罚决定书个人,
            行政处罚决定书单位,
            行政处罚决定书个人,
            文书送达回执,
        }
        /// <summary>
        /// 文书示例--催缴与分期罚款
        /// </summary>
        public enum ECallsFineType
        { 
            罚款催缴通知书 = 110,
            分期缴款审批书,
            分期缴款批准书,
        }
        
        /// <summary>
        /// 文书示例--结案与延期结案
        /// </summary>
        public enum ECaseCloasedType
        { 
            结案审批表 = 120,
            案件延期办结审批表L本级R,
            案件延期办结审批表L上级R,
        }
        #endregion


        /// <summary>
        /// 文书示例
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="InstrumentsExampleTitle"></param>
        /// <param name="ParentType"></param>
        /// <param name="ChildType"></param>
        /// <returns>实例集合</returns>
        internal EList<InstrumentsExample> InstrumentsExampleGetAll(int page, int pageSize, string InstrumentsExampleTitle, int ParentType, int ChildType)
        {
            EList<InstrumentsExample> InstrumentsExamples = new EList<InstrumentsExample>();

            List<WhereClip> Clips = new List<WhereClip>();
            if (InstrumentsExampleTitle != "")
            {
                Clips.Add(DataBases.InstrumentsExample.InstrumentsTitle.Like("%" + InstrumentsExampleTitle + "%"));
            }
            if (ParentType >= (int)SOA.ORM.InstrumentsExample.EInstrumentsType.现场检查)
            {
                Clips.Add(DataBases.InstrumentsExample.InstrumentsType == ParentType);
            }
            if (ChildType >= (int)SOA.ORM.InstrumentsExample.ESiteInspectionType.现场检查记录)
            {
                Clips.Add(DataBases.InstrumentsExample.InstrumentsChildType == ChildType);
            }
            SelectSqlSection section = DB.Select(DataBases.InstrumentsExample, DataBases.InstrumentsExample.ID.Count());
            if (Clips.Count > 0)
                section.Where(Clips);

            int count = Convert.ToInt32(section.ToScalar());
            InstrumentsExamples.TotalCount = count;
            if (count > 0)
            {
                section = DB.Select(DataBases.InstrumentsExample);
                if (Clips.Count > 0)
                    section.Where(Clips);

                section.SetSelectRange(pageSize, (pageSize * (page - 1)), DataBases.InstrumentsExample.ID);

                using (IDataReader reader = section.ToDataReader())
                {
                    while (reader.Read())
                    {
                        InstrumentsExample InstrumentsExample = ReadRow(reader);
                        InstrumentsExamples.Items.Add(InstrumentsExample);
                    }
                }
            }

            return InstrumentsExamples;
        }
    }
}
