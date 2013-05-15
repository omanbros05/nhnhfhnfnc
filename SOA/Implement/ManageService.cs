using System;
using System.Collections.Generic;
using System.Text;
using SOA.ORM;

namespace SOA
{
    public partial class SystemService : ISystemService
    {
        /// <summary>
        /// 获取搜索项
        /// </summary>
        /// <param name="TypeNames"></param>
        /// <returns></returns>
        public List<SearchWord> SearchWordGetAll(params string[] TypeNames)
        {
            try
            {
                SearchWord searchWord = new SearchWord();
                searchWord.SystemService = this;
                return searchWord.SearchWordGetAll(TypeNames);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 插入搜索对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void InsertWord<T>(T t) where T : EntityInterface, new()
        {
            try
            {
                SearchWord searchWord = new SearchWord();
                searchWord.SystemService = this;
                searchWord.InsertWord<T>(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取行政区域代码集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="code">代码</param>
        /// <param name="name">地域名称</param>
        /// <returns>实体集合</returns>
        public EList<AreaCode> AreaCodeGetAll(int page, int pageSize, string code, string name)
        {
            try
            {
                AreaCode areaCode = new AreaCode();
                areaCode.SystemService = this;
                return areaCode.AreaCodeGetAll(page, pageSize, code, name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 取得区域最大排序号
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        public int AreaCodeMaxOrderId(int ParentID)
        {
            try
            {
                AreaCode areaCode = new AreaCode();
                areaCode.SystemService = this;
                return areaCode.MaxOrderId(ParentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 栏目上移下移
        /// </summary>
        /// <param name="Id">移动栏目编号</param>
        /// <param name="IfUp">是否上移</param>
        /// <param name="Value">移动数量</param>
        public void AreaCodeMoveAction(int Id, bool IfUp, int Value)
        {
            try
            {
                AreaCode areaCode = new AreaCode();
                areaCode.SystemService = this;
                areaCode.MoveAction(Id, IfUp, Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        /// <summary>
        /// 获取公司信息集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <param name="CompanyType">企业类型</param>
        /// <returns>实体集合</returns>
        public EList<Company> CompanyGetAll(int page, int pageSize, string name,int CompanyType)
        {
            try
            {
                Company company = new Company();
                company.SystemService = this;
                return company.CompanyGetAll(page, pageSize, name, CompanyType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取所有企业数据
        /// </summary>
        /// <returns>企业数据集合</returns>
        public List<Company> CompanyGetFastAll()
        {
            try
            {
                Company company = new Company();
                company.SystemService = this;
                return company.CompanyGetFastAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取现场检查记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SpotCheck> SpotCheckGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                SpotCheck spotCheck = new SpotCheck();
                spotCheck.SystemService = this;
                return spotCheck.SpotCheckGetAll(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取现场处理措施决定书
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        ///<param name="docTitle">文档号</param>
        /// <returns>实体集合</returns>
        public EList<SpotHandelDesision> SpotHandelDesisionGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                SpotHandelDesision spotHandelDesision = new SpotHandelDesision();
                spotHandelDesision.SystemService = this;
                return spotHandelDesision.SpotHandelDesisionGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 强制措施决定审批集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="partyName">当事人姓名</param>
        /// <returns>实体集合</returns>
        public EList<ForceMeasureDecisionApprove> ForceMeasureDecisionApproveGetAll(int page, int pageSize, string partyName)
        {
            try
            {
                ForceMeasureDecisionApprove forceMeasureDecisionApprove = new ForceMeasureDecisionApprove();
                forceMeasureDecisionApprove.SystemService = this;
                return forceMeasureDecisionApprove.ForceMeasureDecisionApproveGetAll(page, pageSize, partyName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取现场检查记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<ForceMeasureDecision> ForceMeasureDecisionGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                ForceMeasureDecision forceMeasureDecision = new ForceMeasureDecision();
                forceMeasureDecision.SystemService = this;
                return forceMeasureDecision.ForceMeasureDecisionGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 责令限期整改指令记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<OrderDeadlineReform> OrderDeadlineReformGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                OrderDeadlineReform orderDeadlineReform = new OrderDeadlineReform();
                orderDeadlineReform.SystemService = this;
                return orderDeadlineReform.OrderDeadlineReformGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 现场处理措施决定书（6个月内）
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<SpotHandelDesisionSixtyDay> SpotHandelDesisionSixtyDayGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                SpotHandelDesisionSixtyDay spotHandelDesisionSixtyDay = new SpotHandelDesisionSixtyDay();
                spotHandelDesisionSixtyDay.SystemService = this;
                return spotHandelDesisionSixtyDay.SpotHandelDesisionSixtyDayGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        /// <summary>
        /// 现场处理措施决定书（6个月内）
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<ReformReView> ReformReViewGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                ReformReView reformReView = new ReformReView();
                reformReView.SystemService = this;
                return reformReView.ReformReViewGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 强制措施决定审批集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="partyName">当事人姓名</param>
        /// <returns>实体集合</returns>
        public EList<ReviewOptionApprove> ReviewOptionApproveGetAll(int page, int pageSize, string partyName)
        {
            try
            {
                ReviewOptionApprove reformReView = new ReviewOptionApprove();
                reformReView.SystemService = this;
                return reformReView.ReviewOptionApproveGetAll(page, pageSize, partyName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 行政处罚决定书(单位)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<AdministrativePenaltyCompany> AdministrativePenaltyCompanyGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                AdministrativePenaltyCompany administrativePenaltyCompany = new AdministrativePenaltyCompany();
                administrativePenaltyCompany.SystemService = this;
                return administrativePenaltyCompany.AdministrativePenaltyCompanyGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 行政处罚决定书(个人)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<AdministrativePenaltyPerson> AdministrativePenaltyPersonGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                AdministrativePenaltyPerson administrativePenaltyPerson = new AdministrativePenaltyPerson();
                administrativePenaltyPerson.SystemService = this;
                return administrativePenaltyPerson.AdministrativePenaltyPersonGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 听证会通知书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<HearingNotice> HearingNoticeGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                HearingNotice hearingNotice = new HearingNotice();
                hearingNotice.SystemService = this;
                return hearingNotice.HearingNoticeGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 听证笔录记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<PutDown> PutDownGetAll(int page, int pageSize, string caseName)
        {
            try
            {
                PutDown putDown = new PutDown();
                putDown.SystemService = this;
                return putDown.PutDownGetAll(page, pageSize, caseName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 听证会报告书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<HearingInform> HearingInformGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                HearingInform hearingInform = new HearingInform();
                hearingInform.SystemService = this;
                return hearingInform.HearingInformGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 文书送达回执记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<WritServiceReceipt> WritServiceReceiptGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                WritServiceReceipt writServiceReceipt = new WritServiceReceipt();
                writServiceReceipt.SystemService = this;
                return writServiceReceipt.WritServiceReceiptGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取立案审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<PutOnRecord> PutOnRecordGetAll(int page, int pageSize, string DocTitle, DateTime beginDate, DateTime endDate)
        {
            try
            {
                PutOnRecord putOnRecord = new PutOnRecord();
                putOnRecord.SystemService = this;
                return putOnRecord.PutOnRecordGetAll(page, pageSize, DocTitle, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取询问通知书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="CompanyName">企业名称</param>
        /// <returns>实体集合</returns>
        public EList<NoticeOfEnquiry> NoticeOfEnquiryGetAll(int page, int pageSize, string DocTitle, string CompanyName)
        {
            try
            {
                NoticeOfEnquiry noticeOfEnquiry = new NoticeOfEnquiry();
                noticeOfEnquiry.SystemService = this;
                return noticeOfEnquiry.NoticeOfEnquiryGetAll(page, pageSize, DocTitle, CompanyName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取询问笔录记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<EnquireQuestion> EnquireQuestionGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                EnquireQuestion enquireQuestion = new EnquireQuestion();
                enquireQuestion.SystemService = this;
                return enquireQuestion.EnquireQuestionGetAll(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //------------------------------

        /// <summary>
        /// 获取先行登记保存证据处理决定书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldECompanyName">单位名称</param>
        /// <returns>实体集合</returns>
        public EList<SaveEvidenceProceDecide> SaveEvidenceProceDecideGetAll(int page, int pageSize, string DocTitle, string FieldECompanyName)
        {
            try
            {
                SaveEvidenceProceDecide saveEvidenceProceDecide = new SaveEvidenceProceDecide();
                saveEvidenceProceDecide.SystemService = this;
                return saveEvidenceProceDecide.SaveEvidenceProceDecideGetAll(page, pageSize, DocTitle, FieldECompanyName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取先行登记保存证据处理审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SaveEvidenceProceAudit> SaveEvidenceProceAuditGetAll(int page, int pageSize, string PutOnRecordCaseName)
        {
            try
            {
                SaveEvidenceProceAudit saveEvidenceProceAudit = new SaveEvidenceProceAudit();
                saveEvidenceProceAudit.SystemService = this;
                return saveEvidenceProceAudit.SaveEvidenceProceAuditGetAll(page, pageSize, PutOnRecordCaseName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取先行登记保存证据通知书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SaveEvidenceNotice> SaveEvidenceNoticeGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                SaveEvidenceNotice saveEvidenceNotice = new SaveEvidenceNotice();
                saveEvidenceNotice.SystemService = this;
                return saveEvidenceNotice.SaveEvidenceNoticeGetAll(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取先行登记保存证据审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SaveEvidenceAudit> SaveEvidenceAuditGetAll(int page, int pageSize, string PutOnRecordCaseName)
        {
            try
            {
                SaveEvidenceAudit saveEvidenceAudit = new SaveEvidenceAudit();
                saveEvidenceAudit.SystemService = this;
                return saveEvidenceAudit.SaveEvidenceAuditGetAll(page, pageSize, PutOnRecordCaseName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取抽样取证凭证集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldECompanyName">企业名称</param>
        /// <returns>实体集合</returns>
        public EList<Sampling> SamplingGetAll(int page, int pageSize, string DocTitle, string FieldECompanyName)
        {
            try
            {
                Sampling sampling = new Sampling();
                sampling.SystemService = this;
                return sampling.SamplingGetAll(page, pageSize, DocTitle, FieldECompanyName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取行政处罚集体讨论记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="PutOnRecordCaseName">案件名称</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<PunishmentDiscussRecord> PunishmentDiscussRecordGetAll(int page, int pageSize, string PutOnRecordCaseName, DateTime beginDate, DateTime endDate)
        {
            try
            {
                PunishmentDiscussRecord punishmentDiscussRecord = new PunishmentDiscussRecord();
                punishmentDiscussRecord.SystemService = this;
                return punishmentDiscussRecord.PunishmentDiscussRecordGetAll(page, pageSize, PutOnRecordCaseName, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取询问笔录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<InterrogationRecord> InterrogationRecordGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                InterrogationRecord interrogationRecord = new InterrogationRecord();
                interrogationRecord.SystemService = this;
                return interrogationRecord.InterrogationRecordGetAll(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取勘验笔录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<ExplorationRecord> ExplorationRecordGetAll(int page, int pageSize, string DocTitle)
        {
            try
            {
                ExplorationRecord explorationRecord = new ExplorationRecord();
                explorationRecord.SystemService = this;
                return explorationRecord.ExplorationRecordGetAll(page, pageSize, DocTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取案件终止（撤销）审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<CaseCancel> CaseCancelGetAll(int page, int pageSize, string PutOnRecordDocTitle, DateTime beginDate, DateTime endDate)
        {
            try
            {
                CaseCancel caseCancel = new CaseCancel();
                caseCancel.SystemService = this;
                return caseCancel.CaseCancelGetAll(page, pageSize, PutOnRecordDocTitle, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取鉴定委托书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="AppraisalUnit">鉴定机构</param>
        /// <returns>实体集合</returns>
        public EList<AppraisalEntrust> AppraisalEntrustGetAll(int page, int pageSize, string DocTitle, string AppraisalUnit)
        {
            try
            {
                AppraisalEntrust appraisalEntrust = new AppraisalEntrust();
                appraisalEntrust.SystemService = this;
                return appraisalEntrust.AppraisalEntrustGetAll(page, pageSize, DocTitle, AppraisalUnit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //------------

        /// <summary>
        /// 获取行政当场处罚决定书单位集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚单位</param>
        /// <returns>实体集合</returns>
        public EList<SpotPunishmentDecisionUnit> SpotPunishmentDecisionUnitGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCompanyName)
        {
            try
            {
                SpotPunishmentDecisionUnit spotPunishmentDecisionUnit = new SpotPunishmentDecisionUnit();
                spotPunishmentDecisionUnit.SystemService = this;
                return spotPunishmentDecisionUnit.SpotPunishmentDecisionUnitGetAll(page, pageSize, DocTitle, PutOnRecordCompanyName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取行政当场处罚决定书个人集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚人</param>
        /// <returns>实体集合</returns>
        public EList<SpotPunishmentDecisionPersonal> SpotPunishmentDecisionPersonalGetAll(int page, int pageSize, string DocTitle, string FieldEPeopleName)
        {
            try
            {
                SpotPunishmentDecisionPersonal spotPunishmentDecisionPersonal = new SpotPunishmentDecisionPersonal();
                spotPunishmentDecisionPersonal.SystemService = this;
                return spotPunishmentDecisionPersonal.SpotPunishmentDecisionPersonalGetAll(page, pageSize, DocTitle,FieldEPeopleName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取行政处罚决定书单位集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚单位</param>
        /// <returns>实体集合</returns>
        public EList<PunishmentDecisionUnit> PunishmentDecisionUnitGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCompanyName)
        {
            try
            {
                PunishmentDecisionUnit punishmentDecisionUnit = new PunishmentDecisionUnit();
                punishmentDecisionUnit.SystemService = this;
                return punishmentDecisionUnit.PunishmentDecisionUnitGetAll(page, pageSize, DocTitle, PutOnRecordCompanyName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取行政处罚决定书个人集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚人</param>
        /// <returns>实体集合</returns>
        public EList<PunishmentDecisionPersonal> PunishmentDecisionPersonalGetAll(int page, int pageSize, string DocTitle, string FieldEPeopleName)
        {
            try
            {
                PunishmentDecisionPersonal punishmentDecisionPersonal = new PunishmentDecisionPersonal();
                punishmentDecisionPersonal.SystemService = this;
                return punishmentDecisionPersonal.PunishmentDecisionPersonalGetAll(page, pageSize, DocTitle, FieldEPeopleName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取文书送达回执集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<DocumentsServiceReply> DocumentsServiceReplyGetAll(int page, int pageSize, string DocTitle)
        {
            try
            {
                DocumentsServiceReply documentsServiceReply = new DocumentsServiceReply();
                documentsServiceReply.SystemService = this;
                return documentsServiceReply.DocumentsServiceReplyGetAll(page, pageSize, DocTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取鉴定委托书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="PutOnRecordCaseName">案件名称</param>
        /// <returns>实体集合</returns>
        public EList<InCaseOfTable> InCaseOfTableGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCaseName)
        {
            try
            {
                InCaseOfTable inCaseOfTable = new InCaseOfTable();
                inCaseOfTable.SystemService = this;
                return inCaseOfTable.InCaseOfTableGetAll(page, pageSize, DocTitle, PutOnRecordCaseName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取工作人员信息集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">工作人员姓名</param>
        /// <returns>实体集合</returns>
        public EList<Officers> OfficersGetAll(int page, int pageSize, string name)
        {
            try
            {
                Officers officers = new Officers();
                officers.SystemService = this;
                return officers.OfficersGetAll(page, pageSize, name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据参数更新工作人员
        /// </summary>
        /// <param name="officersName">姓名</param>
        /// <param name="officers">工作人员</param>
        public void UpdateOfficersByArgs(Officers officers)
        {
            try
            {
                Officers obj = new Officers();
                obj.SystemService = this;
                obj.UpdateOfficersByArgs(officers);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据名称和帐号更新银行信息
        /// </summary>
        ///<param name="bank">银行</param>
        public void UpdateBankByNameAccount(Bank bank)
        {
            try
            {
                Bank obj = new Bank();
                obj.SystemService = this;
                obj.UpdateByNameAccount(bank);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据名称更新企业信息
        /// </summary>
        /// <param name="company">企业对象</param>
        public void UpdateCompanyByName(Company company)
        {
            try
            {
                Company obj = new Company();
                obj.SystemService = this;
                obj.UpdateCompanyByName(company);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 更新自然人
        /// </summary>
        /// <param name="person">自然人</param>
        public void UpdateNaturalPersonByArgs(NaturalPerson person)
        {
            try
            {
                NaturalPerson obj = new NaturalPerson();
                obj.SystemService = this;
                obj.UpdateNaturalPersonByArgs(person);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 更新检查地点
        /// </summary>
        /// <param name="checkPlace">检查地点</param>
        public void UpdateCheckPlace(CheckPlace checkPlace)
        {
            try
            {
                CheckPlace obj = new CheckPlace();
                obj.SystemService = this;
                obj.UpdateCheckPlace(checkPlace);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 更新律师记录
        /// </summary>
        /// <param name="lawyer">律师对象</param>
        public void UpdateLawyer(Lawyer lawyer)
        {
            try
            {
                Lawyer obj = new Lawyer();
                obj.SystemService = this;
                obj.UpdateLowyer(lawyer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 根据名称更新违法行为
        /// </summary>
        /// <param name="illegalType">违法行为对象</param>
        public void UpdateIllegalTypeByName(IllegalType illegalType)
        {
            try
            {
                IllegalType obj = new IllegalType();
                obj.SystemService = this;
                obj.UpdateIllegalTypeByName(illegalType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据名称更新案件来源
        /// </summary>
        /// <param name="caseSource">案件来源对象</param>
        public void UpdateCaseSourceByName(CaseSource caseSource)
        {
            try
            {
                CaseSource obj = new CaseSource();
                obj.SystemService = this;
                obj.UpdateCaseSourceByName(caseSource);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 取抽样取证凭证表文号
        /// </summary>
        /// <param name="SamplingID">编号</param>
        /// <returns></returns>
        public string GetSamplingDocTitle(int SamplingID)
        {
            try
            {
                Sampling sampling = new Sampling();
                sampling.SystemService = this;
                return sampling.GetSamplingDocTitle(SamplingID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 取抽样取证凭证表编号
        /// </summary>
        /// <param name="SamplingDocTitle">文号</param>
        /// <returns></returns>
        public int GetSamplingID(string SamplingDocTitle)
        {
            try
            {
                Sampling sampling = new Sampling();
                sampling.SystemService = this;
                return sampling.GetSamplingID(SamplingDocTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 取物品内容
        /// </summary>
        /// <param name="SamplingID">抽样取证凭证编号</param>
        /// <returns></returns>
        public List<SamplingContent> GetSamplingContentAll(int SamplingID)
        {
            try
            {
                SamplingContent samplingContent = new SamplingContent();
                samplingContent.SystemService = this;
                return samplingContent.GetSamplingContentAll(SamplingID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 更新问题记录
        /// </summary>
        /// <param name="lawyer">问题对象</param>
        public void UpdateQuestion(Question question)
        {
            try
            {
                Question obj = new Question();
                obj.SystemService = this;
                obj.UpdateQuestion(question);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取活动用户对象
        /// </summary>
        /// <returns></returns>
        public UserInfo GetActiveUser()
        {
            try
            {
                UserInfo userInfo = new UserInfo();
                userInfo.SystemService = this;
                return userInfo.GetActiveUser();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取现场照片记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SpotShoot> SpotShootGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                SpotShoot spotShoot = new SpotShoot();
                spotShoot.SystemService = this;
                return spotShoot.SpotShootGetAll(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EList<Archive> ArchiveGetAll() {
            try {
                Archive entity = new Archive();
                entity.SystemService = this;
                return entity.ArchiveGetAll();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public EList<ArchiveExtEntity> ArchiveExtGetAll(int archiveID) {

            try {
                ArchiveExtEntity entity = new ArchiveExtEntity();
                entity.SystemService = this;
                return entity.ArchiveExtGetAll(archiveID);
            } catch (Exception ex) { throw ex; }
        }
    }
}
