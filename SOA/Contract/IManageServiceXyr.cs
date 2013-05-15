using System;
using System.Collections.Generic;
using System.Text;
using SOA.ORM;

namespace SOA
{
    public partial interface ISystemService
    {
        /// <summary>
        /// 获取行政处罚告知书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<AdminPunishNotification> AdminPunishNotificationBySendDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 获取结案审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<CaseClosedApproval> CaseClosedApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 获取案件延期办结审批表(上级)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<CaseExtensionClosedApproval> CaseExtensionClosedApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 获取案件延期办结审批表(本级)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<CaseExtensionClosedApprovalToSibling> CaseExtensionClosedApprovalToSiblingByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 案件移送审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<CaseTransferredApproval> CaseTransferredApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 案件移送表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<CaseTransferred> CaseTransferredByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

          /// <summary>
        /// 获取延期（分期）缴纳罚款审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<ContributeFineApproval> ContributeFineApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

         /// <summary>
        /// 获取延期（分期）缴纳罚款批准书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<ContributeFine> ContributeFineByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

         /// <summary>
        /// 获取罚款催缴通知书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<FineCallsNotice> FineCallsNoticeByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 行政处罚案件调查终结报告列表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        EList<SurveyEndReport> SurveyEndReportGetAll(int page, int pageSize, string docTitle);

        /// <summary>
        /// 查封（扣押）决定审批表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SealDecideApproval> SealDecideApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 查封（扣押）决定书
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SealDecide> SealDecideByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 查封（扣押）物品处理决定审批表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SealThingHandleApproval> SealThingHandleApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

          /// <summary>
        /// 查封（扣押）物品处理决定审批表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<SealThingHandle> SealThingHandleByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

         /// <summary>
        /// 当事人陈诉申辩笔录
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<DefenseRecords> DefenseRecordsByDate(int page, int pageSize, DateTime beginDate, DateTime endDate);

        /// <summary>
        /// 危险化学品经营许可表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        EList<CompanyDangerChemicals> CompanyDangerChemicalsGetAll(int page, int pageSize, string name, int IsCity, int AreaID);

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
        EList<ChemicalsList> ChemicalsListGetAll(int page, int pageSize, string Number, string Name, string alias, int Type, int ChildType,string UN);

        /// <summary>
        /// 危险化学品生产（含溶剂回收）、储存详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        EList<CompanyDangerChemicalsProduce> CompanyDangerChemicalsProduceGetAll(int page, int pageSize, string name, int IsCity, int AreaID);
        /// <summary>
        /// 烟花爆竹零售详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        EList<CompanyFireworks> CompanyFireworksGetAll(int page, int pageSize, string name, int IsCity, int AreaID);

        /// <summary>
        /// 剧毒化学品使用详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        EList<CompanyHighlyToxicChemicals> CompanyHighlyToxicChemicalsGetAll(int page, int pageSize, string name, int IsCity, int AreaID);
        /// <summary>
        /// 非煤矿山安全生产许可企业详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        EList<CompanyNoCoalSecurity> CompanyNoCoalSecurityGetAll(int page, int pageSize, string name, int IsCity, int AreaID);

        /// <summary>
        /// 法律法规
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        EList<LawFile> LawFileGetAll(int page, int pageSize, string LawFileTitle, int LawType);

           /// <summary>
        /// 剧毒化学品目录
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="ChemicalName">化学名</param>
        /// <param name="ChemicalAlias">别名</param>
        /// <returns></returns>
        EList<ChemicalsHighlyToxic> ChemicalsHighlyToxicGetAll(int page, int pageSize, string ChemicalName, string ChemicalAlias);

        /// <summary>
        /// 文书示例
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="InstrumentsExampleTitle"></param>
        /// <param name="ParentType"></param>
        /// <param name="ChildType"></param>
        /// <returns>实例集合</returns>
        EList<InstrumentsExample> InstrumentsExampleGetAll(int page, int pageSize, string InstrumentsExampleTitle, int ParentType, int ChildType);

        /// <summary>
        /// 危险化学品经营许可表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        CompanyDangerChemicals CompanyDangerChemicalsGetOne(int CompanyID);

         /// <summary>
        /// 危险化学品生产(含溶剂回收)、储存详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        CompanyDangerChemicalsProduce CompanyDangerChemicalsProduceGetOne(int CompanyID);

        /// <summary>
        /// 烟花爆竹零售详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        CompanyFireworks CompanyFireworksGetOne(int CompanyID);

        /// <summary>
        /// 剧毒化学品使用详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        CompanyHighlyToxicChemicals CompanyHighlyToxicChemicalsGetOne(int CompanyID);

        /// <summary>
        /// 非煤矿山安全生产许可企业详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        CompanyNoCoalSecurity CompanyNoCoalSecurityGetOne(int CompanyID);

        /// <summary>
        /// 历史文书的文件夹集合
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="ParentType"></param>
        /// <param name="ChildType"></param>
        /// <param name="Year"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        EList<InstrumentsHistoryFolder> InstrumentsHistoryFolderGetAll(int page, int pageSize, int ParentType, int ChildType, int Year, int Month);

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
        EList<InstrumentsHistoryFile> InstrumentsHistoryFileGetAll(int page, int pageSize, string Title, string CompanyName, string TabelName, int TableID);

        /// <summary>
        /// 地区实体
        /// </summary>
        /// <param name="name">地区名称</param>
        /// <returns>实体</returns>
        CompanyArea CompanyAreaGetOne(string name);

        /// <summary>
        /// 地区集合
        /// </summary>
        /// <returns>实体集合</returns>
        EList<CompanyArea> CompanyAreaGetAll();

        /// <summary>
        /// 获取权力清单集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="Name">权力名称</param>
        /// <param name="PowerType">权力类型</param>
        /// <returns>实体集合</returns>
        EList<PowerInventory> PowerGetAll(int page, int pageSize, string Name, int PowerType);

        /// <summary>
        /// 获取所有企业类型数据
        /// </summary>
        /// <returns>企业类型集合</returns>
        List<CompanyType> CompanyTypeGetFastAll();

        /// <summary>
        /// 获取公司信息结合
        /// </summary>
        /// <param name="page">分页</param>
        /// <param name="pageSize"></param>
        /// <param name="name">名称</param>
        /// <param name="CompanyType">类型</param>
        /// <param name="CompanyArea">区域</param>
        /// <param name="IsCity">是否市级</param>
        /// <returns></returns>
        EList<Company> CompanyNewGetAll(int page, int pageSize, string name, int CompanyType, int CompanyArea, int IsCity);

        /// <summary>
        /// 获取公司信息结合
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        EList<Company> CompanyGetAllByName(string name);

    }
}
