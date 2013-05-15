using System;

namespace Maleos.Model
{
    /// <summary>
    /// 立案审批表实体类
    /// </summary>
    [Serializable]
    public class ApprovalCasesInfo
    {
        // 内部成员变量
        private int approvalCasesId;
        private string areaAbbr;
        private int approvalYear;
        private int approvalNum;
        private string caseReason;
        private string caseFrom;
        private DateTime approvalTime;
        private string caseName;
        private FactoryInfo factory;
        private string situation;
        private string opinion;
        private OfficerInfo officer;
        private DateTime current;

        
        /// <summary>
        /// 默认构造函数
        /// Web Service 需要的一种序列化机制
        /// </summary>
        public ApprovalCasesInfo() { }

        /// <summary>
        /// 构造函数，根据指定的值初始化成员变量
        /// </summary>
        /// <param name="approvalCasesId">主键ID的表示</param>
        /// <param name="areaAbbr">区域简称</param>
        /// <param name="approvalYear">当前年份</param>
        /// <param name="approvalNum">文书编号</param>
        /// <param name="caseReason">立案原由</param>
        /// <param name="caseFrom">案件来源</param>
        /// <param name="approvalTime">立案时间</param>
        /// <param name="caseName">案件名称</param>
        /// <param name="factory">立案审批使用到的企业信息</param>
        /// <param name="situation">案件的情况</param>
        /// <param name="opinion">案件处理的初始意见</param>
        /// <param name="officer">立案审批使用到的执法人员信息</param>
        /// <param name="current">当前日期</param>
        public ApprovalCasesInfo(int approvalCasesId, string areaAbbr, int approvalYear, int approvalNum, string caseReason,
            string caseFrom, DateTime approvalTime, string caseName, FactoryInfo factory, string situation, string opinion,
            OfficerInfo officer, DateTime current) {
            this.approvalCasesId = approvalCasesId;
            this.areaAbbr = areaAbbr;
            this.approvalYear = approvalYear;
            this.approvalNum = approvalNum;
            this.caseReason = caseReason;
            this.caseFrom = caseFrom;
            this.approvalTime = approvalTime;
            this.caseName = caseName;
            this.factory = factory;
            this.situation = situation;
            this.opinion = opinion;
            this.officer = officer;
            this.current = current;
        }

        // 外部属性
        public int ApprovalCasesId {
            get { return approvalCasesId; }
            set { approvalCasesId = value; }
        }

        public string AreaAbbr {
            get { return areaAbbr; }
            set { areaAbbr = value; }
        }

        public int ApprovalYear {
            get { return approvalYear; }
            set { approvalYear = value; }
        }

        public int ApprovalNum {
            get { return approvalNum; }
            set { approvalNum = value; }
        }

        public string CaseReason {
            get { return caseReason; }
            set { caseReason = value; }
        }

        public string CaseFrom {
            get { return caseFrom; }
            set { caseFrom = value; }
        }

        public DateTime ApprovalTime {
            get { return approvalTime; }
            set { approvalTime = value; }
        }

        public string CaseName {
            get { return caseName; }
            set { caseName = value; }
        }

        public FactoryInfo Factory {
            get { return factory; }
            set { factory = value; }
        }

        public string Situation {
            get { return situation; }
            set { situation = value; }
        }

        public string Opinion {
            get { return opinion; }
            set { opinion = value; }
        }

        public OfficerInfo Officer {
            get { return officer; }
            set { officer = value; }
        }

        public DateTime Current {
            get { return current; }
            set { current = value; }
        }
    }
}
