using System;
using System.Collections.Generic;
using System.Text;
using SOA.ORM;

namespace SOA
{
    public partial interface ISystemService
    {
        /// <summary>
        /// 获取搜索项
        /// </summary>
        /// <param name="TypeNames"></param>
        /// <returns></returns>
        List<SearchWord> SearchWordGetAll(params string[] TypeNames);

        /// <summary>
        /// 插入搜索对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        void InsertWord<T>(T t) where T : EntityInterface, new();

        /// <summary>
        /// 获取行政区域代码集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="code">代码</param>
        /// <param name="name">地域名称</param>
        /// <returns>实体集合</returns>
        EList<AreaCode> AreaCodeGetAll(int page, int pageSize, string code, string name);

        /// <summary>
        /// 取得区域最大排序号
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        int AreaCodeMaxOrderId(int ParentID);
        /// <summary>
        /// 栏目上移下移
        /// </summary>
        /// <param name="Id">移动栏目编号</param>
        /// <param name="IfUp">是否上移</param>
        /// <param name="Value">移动数量</param>
        void AreaCodeMoveAction(int Id, bool IfUp, int Value);


        /// <summary>
        /// 获取公司信息集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <param name="CompanyType">企业类型</param>
        /// <returns>实体集合</returns>
        EList<Company> CompanyGetAll(int page, int pageSize, string name,int CompanyType);

        /// <summary>
        /// 获取所有企业数据
        /// </summary>
        /// <returns>企业数据集合</returns>
        List<Company> CompanyGetFastAll();

        /// <summary>
        /// 获取现场检查记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SpotCheck> SpotCheckGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 获取现场处理措施决定书
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        ///<param name="docTitle">文档号</param>
        /// <returns>实体集合</returns>
        EList<SpotHandelDesision> SpotHandelDesisionGetAll(int page, int pageSize, string docTitle);

        /// <summary>
        /// 强制措施决定审批集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="partyName">当事人姓名</param>
        /// <returns>实体集合</returns>
        EList<ForceMeasureDecisionApprove> ForceMeasureDecisionApproveGetAll(int page, int pageSize, string partyName);

         /// <summary>
        /// 获取现场检查记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<ForceMeasureDecision> ForceMeasureDecisionGetAll(int page, int pageSize, string docTitle);

         /// <summary>
        /// 责令限期整改指令记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<OrderDeadlineReform> OrderDeadlineReformGetAll(int page, int pageSize, string docTitle);
        
        /// <summary>
        /// 现场处理措施决定书（6个月内）
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<SpotHandelDesisionSixtyDay> SpotHandelDesisionSixtyDayGetAll(int page, int pageSize, string docTitle);

        /// <summary>
        /// 现场处理措施决定书（6个月内）
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<ReformReView> ReformReViewGetAll(int page, int pageSize, string docTitle);

        /// <summary>
        /// 强制措施决定审批集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="partyName">当事人姓名</param>
        /// <returns>实体集合</returns>
        EList<ReviewOptionApprove> ReviewOptionApproveGetAll(int page, int pageSize, string partyName);

        /// <summary>
        /// 行政处罚决定书(单位)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<AdministrativePenaltyCompany> AdministrativePenaltyCompanyGetAll(int page, int pageSize, string docTitle);

        /// <summary>
        /// 行政处罚决定书(个人)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<AdministrativePenaltyPerson> AdministrativePenaltyPersonGetAll(int page, int pageSize, string docTitle);

         /// <summary>
        /// 听证会通知书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<HearingNotice> HearingNoticeGetAll(int page, int pageSize, string docTitle);

        /// <summary>
        /// 听证笔录记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<PutDown> PutDownGetAll(int page, int pageSize, string caseName);

        /// <summary>
        /// 听证会报告书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<HearingInform> HearingInformGetAll(int page, int pageSize, string docTitle);

         /// <summary>
        /// 文书送达回执记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<WritServiceReceipt> WritServiceReceiptGetAll(int page, int pageSize, string docTitle);
        /// <summary>
        /// 获取立案审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<PutOnRecord> PutOnRecordGetAll(int page, int pageSize, string DocTitle, DateTime beginDate, DateTime endDate);
        /// <summary>
        /// 获取询问通知书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="CompanyName">企业名称</param>
        /// <returns>实体集合</returns>
        EList<NoticeOfEnquiry> NoticeOfEnquiryGetAll(int page, int pageSize, string DocTitle, string CompanyName);
        /// <summary>
        /// 获取询问笔录记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<EnquireQuestion> EnquireQuestionGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate);

        //---------------------
        /// <summary>
        /// 获取先行登记保存证据处理决定书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldECompanyName">单位名称</param>
        /// <returns>实体集合</returns>
        EList<SaveEvidenceProceDecide> SaveEvidenceProceDecideGetAll(int page, int pageSize, string DocTitle, string FieldECompanyName);
                /// <summary>
        /// 获取先行登记保存证据处理审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SaveEvidenceProceAudit> SaveEvidenceProceAuditGetAll(int page, int pageSize, string PutOnRecordCaseName);
        /// <summary>
        /// 获取先行登记保存证据通知书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SaveEvidenceNotice> SaveEvidenceNoticeGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate);
        /// <summary>
        /// 获取先行登记保存证据审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SaveEvidenceAudit> SaveEvidenceAuditGetAll(int page, int pageSize, string PutOnRecordCaseName);
        /// <summary>
        /// 获取抽样取证凭证集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldECompanyName">企业名称</param>
        /// <returns>实体集合</returns>
        EList<Sampling> SamplingGetAll(int page, int pageSize, string DocTitle, string FieldECompanyName);
        /// <summary>
        /// 获取行政处罚集体讨论记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="PutOnRecordCaseName">案件名称</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<PunishmentDiscussRecord> PunishmentDiscussRecordGetAll(int page, int pageSize, string PutOnRecordCaseName, DateTime beginDate, DateTime endDate);
        /// <summary>
        /// 获取询问笔录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<InterrogationRecord> InterrogationRecordGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate);
        /// <summary>
        /// 获取勘验笔录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<ExplorationRecord> ExplorationRecordGetAll(int page, int pageSize, string DocTitle);
        /// <summary>
        /// 获取案件终止（撤销）审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<CaseCancel> CaseCancelGetAll(int page, int pageSize, string PutOnRecordDocTitle, DateTime beginDate, DateTime endDate);
        /// <summary>
        /// 获取鉴定委托书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="AppraisalUnit">鉴定机构</param>
        /// <returns>实体集合</returns>
        EList<AppraisalEntrust> AppraisalEntrustGetAll(int page, int pageSize, string DocTitle, string AppraisalUnit);

        /// <summary>
        /// 获取行政当场处罚决定书单位集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚单位</param>
        /// <returns>实体集合</returns>
        EList<SpotPunishmentDecisionUnit> SpotPunishmentDecisionUnitGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCompanyName);
        /// <summary>
        /// 获取行政当场处罚决定书个人集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚人</param>
        /// <returns>实体集合</returns>
        EList<SpotPunishmentDecisionPersonal> SpotPunishmentDecisionPersonalGetAll(int page, int pageSize, string DocTitle, string FieldEPeopleName);
        /// <summary>
        /// 获取行政处罚决定书单位集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚单位</param>
        /// <returns>实体集合</returns>
        EList<PunishmentDecisionUnit> PunishmentDecisionUnitGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCompanyName);
        /// <summary>
        /// 获取行政处罚决定书个人集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="FieldEPeopleName">被惩罚人</param>
        /// <returns>实体集合</returns>
        EList<PunishmentDecisionPersonal> PunishmentDecisionPersonalGetAll(int page, int pageSize, string DocTitle, string FieldEPeopleName);
        /// <summary>
        /// 获取文书送达回执集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<DocumentsServiceReply> DocumentsServiceReplyGetAll(int page, int pageSize, string DocTitle);
        /// <summary>
        /// 获取鉴定委托书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="DocTitle">文号</param>
        /// <param name="PutOnRecordCaseName">案件名称</param>
        /// <returns>实体集合</returns>
        EList<InCaseOfTable> InCaseOfTableGetAll(int page, int pageSize, string DocTitle, string PutOnRecordCaseName);

        /// <summary>
        /// 获取工作人员信息集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">工作人员姓名</param>
        /// <returns>实体集合</returns>
        EList<Officers> OfficersGetAll(int page, int pageSize, string name);

        /// <summary>
        /// 根据参数更新工作人员
        /// </summary>
        /// <param name="officersName">姓名</param>
        /// <param name="officers">工作人员</param>
        void UpdateOfficersByArgs(Officers officers);

         /// <summary>
        /// 根据名称和帐号更新银行信息
        /// </summary>
        ///<param name="bank">银行</param>
        void UpdateBankByNameAccount(Bank bank);

        /// <summary>
        /// 根据名称更新企业信息
        /// </summary>
        /// <param name="company">企业对象</param>
        void UpdateCompanyByName(Company company);

        /// <summary>
        /// 更新自然人
        /// </summary>
        /// <param name="person">自然人</param>
        void UpdateNaturalPersonByArgs(NaturalPerson person);

        /// <summary>
        /// 更新检查地点
        /// </summary>
        /// <param name="checkPlace">检查地点</param>
        void UpdateCheckPlace(CheckPlace checkPlace);

         /// <summary>
        /// 更新律师记录
        /// </summary>
        /// <param name="lawyer">律师对象</param>
        void UpdateLawyer(Lawyer lawyer);
        /// <summary>
        /// 取抽样取证凭证表文号
        /// </summary>
        /// <param name="SamplingID">编号</param>
        /// <returns></returns>
        string GetSamplingDocTitle(int SamplingID);
        /// <summary>
        /// 取抽样取证凭证表编号
        /// </summary>
        /// <param name="SamplingDocTitle">文号</param>
        /// <returns></returns>
        int GetSamplingID(string SamplingDocTitle);
        /// <summary>
        /// 取物品内容
        /// </summary>
        /// <param name="SamplingID">抽样取证凭证编号</param>
        /// <returns></returns>
        List<SamplingContent> GetSamplingContentAll(int SamplingID);

        
        /// <summary>
        /// 根据名称更新违法行为
        /// </summary>
        /// <param name="illegalType">违法行为对象</param>
        void UpdateIllegalTypeByName(IllegalType illegalType);
        /// <summary>
        /// 根据名称更新案件来源
        /// </summary>
        /// <param name="caseSource">案件来源对象</param>
        void UpdateCaseSourceByName(CaseSource caseSource);

        /// <summary>
        /// 更新问题记录
        /// </summary>
        /// <param name="lawyer">问题对象</param>
        void UpdateQuestion(Question question);

        /// <summary>
        /// 获取活动用户对象
        /// </summary>
        /// <returns></returns>
        UserInfo GetActiveUser();

        /// <summary>
        /// 获取现场照片记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SpotShoot> SpotShootGetAll(int page, int pageSize, DateTime beginDate, DateTime endDate);

        EList<Archive> ArchiveGetAll();

        EList<ArchiveExtEntity> ArchiveExtGetAll(int archiveID);
    }
}
