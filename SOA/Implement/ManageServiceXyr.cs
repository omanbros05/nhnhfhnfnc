using System;
using System.Collections.Generic;
using System.Text;
using SOA.ORM;

namespace SOA
{
    public partial class SystemService : ISystemService
    {
        /// <summary>
        /// 获取行政处罚告知书记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<AdminPunishNotification> AdminPunishNotificationBySendDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                AdminPunishNotification Obj = new AdminPunishNotification();
                Obj.SystemService = this;
                return Obj.AdminPunishNotificationBySendDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取结案审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<CaseClosedApproval> CaseClosedApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                CaseClosedApproval Obj = new CaseClosedApproval();
                Obj.SystemService = this;
                return Obj.CaseClosedApprovalByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取案件延期办结审批表(上级)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<CaseExtensionClosedApproval> CaseExtensionClosedApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                CaseExtensionClosedApproval Obj = new CaseExtensionClosedApproval();
                Obj.SystemService = this;
                return Obj.CaseExtensionClosedApprovalByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取案件延期办结审批表(本级)记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<CaseExtensionClosedApprovalToSibling> CaseExtensionClosedApprovalToSiblingByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                CaseExtensionClosedApprovalToSibling Obj = new CaseExtensionClosedApprovalToSibling();
                Obj.SystemService = this;
                return Obj.CaseExtensionClosedApprovalToSiblingByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 案件移送审批表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<CaseTransferredApproval> CaseTransferredApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                CaseTransferredApproval Obj = new CaseTransferredApproval();
                Obj.SystemService = this;
                return Obj.CaseTransferredApprovalByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 案件移送表记录集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<CaseTransferred> CaseTransferredByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                CaseTransferred Obj = new CaseTransferred();
                Obj.SystemService = this;
                return Obj.CaseTransferredByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// 获取延期（分期）缴纳罚款审批表集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<ContributeFineApproval> ContributeFineApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                ContributeFineApproval Obj = new ContributeFineApproval();
                Obj.SystemService = this;
                return Obj.ContributeFineApprovalByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取延期（分期）缴纳罚款批准书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<ContributeFine> ContributeFineByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                ContributeFine Obj = new ContributeFine();
                Obj.SystemService = this;
                return Obj.ContributeFineByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取罚款催缴通知书集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<FineCallsNotice> FineCallsNoticeByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                FineCallsNotice Obj = new FineCallsNotice();
                Obj.SystemService = this;
                return Obj.FineCallsNoticeByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 行政处罚案件调查终结报告列表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="docTitle">文号</param>
        /// <returns>实体集合</returns>
        public EList<SurveyEndReport> SurveyEndReportGetAll(int page, int pageSize, string docTitle)
        {
            try
            {
                SurveyEndReport Obj = new SurveyEndReport();
                Obj.SystemService = this;
                return Obj.SurveyEndReportGetAll(page, pageSize, docTitle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查封（扣押）决定审批表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SealDecideApproval> SealDecideApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                SealDecideApproval Obj = new SealDecideApproval();
                Obj.SystemService = this;
                return Obj.SealDecideApprovalByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查封（扣押）决定书
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SealDecide> SealDecideByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                SealDecide Obj = new SealDecide();
                Obj.SystemService = this;
                return Obj.SealDecideByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查封（扣押）物品处理决定审批表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SealThingHandleApproval> SealThingHandleApprovalByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                SealThingHandleApproval Obj = new SealThingHandleApproval();
                Obj.SystemService = this;
                return Obj.SealThingHandleApprovalByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         /// <summary>
        /// 查封（扣押）物品处理决定审批表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<SealThingHandle> SealThingHandleByDate(int page, int pageSize, DateTime beginDate, DateTime endDate)
        {
            try
            {
                SealThingHandle Obj = new SealThingHandle();
                Obj.SystemService = this;
                return Obj.SealThingHandleByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         /// <summary>
        /// 当事人陈诉申辩笔录
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<DefenseRecords> DefenseRecordsByDate(int page, int pageSize, DateTime beginDate, DateTime endDate) 
        {
            try
            {
                DefenseRecords Obj = new DefenseRecords();
                Obj.SystemService = this;
                return Obj.DefenseRecordsByDate(page, pageSize, beginDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 危险化学品经营许可表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        public EList<CompanyDangerChemicals> CompanyDangerChemicalsGetAll(int page, int pageSize, string name, int IsCity, int AreaID)
        {
            try
            {
                CompanyDangerChemicals Obj = new CompanyDangerChemicals();
                Obj.SystemService = this;
                return Obj.CompanyDangerChemicalsGetAll(page, pageSize, name, IsCity, AreaID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 危化品名录
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="Number">编号</param>
        /// <param name="Name">名称</param>
        /// <param name="Type">类别</param>
        /// <returns>实体集合</returns>
        public EList<ChemicalsList> ChemicalsListGetAll(int page, int pageSize, string Number, string Name, string alias, int Type, int ChildType,string UN)
        {
            try
            {
                ChemicalsList Obj = new ChemicalsList();
                Obj.SystemService = this;
                return Obj.ChemicalsListGetAll(page, pageSize, Number, Name,alias, Type,ChildType,UN);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 危险化学品生产（含溶剂回收）、储存详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        public EList<CompanyDangerChemicalsProduce> CompanyDangerChemicalsProduceGetAll(int page, int pageSize, string name, int IsCity, int AreaID)
        {
            try
            {
                CompanyDangerChemicalsProduce Obj = new CompanyDangerChemicalsProduce();
                Obj.SystemService = this;
                return Obj.CompanyDangerChemicalsProduceGetAll(page, pageSize, name, IsCity, AreaID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 烟花爆竹零售详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        public EList<CompanyFireworks> CompanyFireworksGetAll(int page, int pageSize, string name, int IsCity, int AreaID)
        {
            try
            {
                CompanyFireworks Obj = new CompanyFireworks();
                Obj.SystemService = this;
                return Obj.CompanyFireworksGetAll(page, pageSize, name,IsCity,AreaID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 剧毒化学品使用详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        public EList<CompanyHighlyToxicChemicals> CompanyHighlyToxicChemicalsGetAll(int page, int pageSize, string name, int IsCity, int AreaID) 
        {
            try
            {
                CompanyHighlyToxicChemicals Obj = new CompanyHighlyToxicChemicals();
                Obj.SystemService = this;
                return Obj.CompanyHighlyToxicChemicalsGetAll(page, pageSize, name, IsCity, AreaID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 非煤矿山安全生产许可企业详情表
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="name">单位名称</param>
        /// <returns>实体集合</returns>
        public EList<CompanyNoCoalSecurity> CompanyNoCoalSecurityGetAll(int page, int pageSize, string name, int IsCity, int AreaID)
        {
            try
            {
                CompanyNoCoalSecurity Obj = new CompanyNoCoalSecurity();
                Obj.SystemService = this;
                return Obj.CompanyNoCoalSecurityGetAll(page, pageSize, name, IsCity, AreaID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 法律法规
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="beginDate">起始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns>实体集合</returns>
        public EList<LawFile> LawFileGetAll(int page, int pageSize, string LawFileTitle, int LawType)
        {
            try
            {
                LawFile Obj = new LawFile();
                Obj.SystemService = this;
                return Obj.LawFileGetAll(page, pageSize, LawFileTitle,LawType);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

           /// <summary>
        /// 剧毒化学品目录
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="ChemicalName">化学名</param>
        /// <param name="ChemicalAlias">别名</param>
        /// <returns></returns>
        public EList<ChemicalsHighlyToxic> ChemicalsHighlyToxicGetAll(int page, int pageSize, string ChemicalName, string ChemicalAlias)
        {
            try
            {
                ChemicalsHighlyToxic Obj = new ChemicalsHighlyToxic();
                Obj.SystemService = this;
                return Obj.ChemicalsHighlyToxicGetAll(page, pageSize, ChemicalName, ChemicalAlias);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 文书示例
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="InstrumentsExampleTitle"></param>
        /// <param name="ParentType"></param>
        /// <param name="ChildType"></param>
        /// <returns>实例集合</returns>
        public EList<InstrumentsExample> InstrumentsExampleGetAll(int page, int pageSize, string InstrumentsExampleTitle, int ParentType, int ChildType)
        {
            try
            {
                InstrumentsExample Obj = new InstrumentsExample();
                Obj.SystemService = this;
                return Obj.InstrumentsExampleGetAll(page, pageSize, InstrumentsExampleTitle, ParentType, ChildType);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 危险化学品经营许可表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        public CompanyDangerChemicals CompanyDangerChemicalsGetOne(int CompanyID)
        {
            try
            {
                CompanyDangerChemicals Obj = new CompanyDangerChemicals();
                Obj.SystemService = this;
                return Obj.CompanyDangerChemicalsGetOne(CompanyID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 危险化学品生产(含溶剂回收)、储存详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        public CompanyDangerChemicalsProduce CompanyDangerChemicalsProduceGetOne(int CompanyID)
        {
            try
            {
                CompanyDangerChemicalsProduce Obj = new CompanyDangerChemicalsProduce();
                Obj.SystemService = this;
                return Obj.CompanyDangerChemicalsProduceGetOne(CompanyID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 烟花爆竹零售详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        public CompanyFireworks CompanyFireworksGetOne(int CompanyID)
        {
            try
            {
                CompanyFireworks Obj = new CompanyFireworks();
                Obj.SystemService = this;
                return Obj.CompanyFireworksGetOne(CompanyID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 剧毒化学品使用详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        public CompanyHighlyToxicChemicals CompanyHighlyToxicChemicalsGetOne(int CompanyID)
        {
            try
            {
                CompanyHighlyToxicChemicals Obj = new CompanyHighlyToxicChemicals();
                Obj.SystemService = this;
                return Obj.CompanyHighlyToxicChemicalsGetOne(CompanyID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 非煤矿山安全生产许可企业详情表
        /// </summary>
        /// <param name="CompanyID">基本信息表编号</param>
        /// <returns>实体</returns>
        public CompanyNoCoalSecurity CompanyNoCoalSecurityGetOne(int CompanyID)
        {
            try
            {
                CompanyNoCoalSecurity Obj = new CompanyNoCoalSecurity();
                Obj.SystemService = this;
                return Obj.CompanyNoCoalSecurityGetOne(CompanyID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
        public EList<InstrumentsHistoryFolder> InstrumentsHistoryFolderGetAll(int page, int pageSize, int ParentType, int ChildType, int Year, int Month)
        {
            try
            {
                InstrumentsHistoryFolder Obj = new InstrumentsHistoryFolder();
                Obj.SystemService = this;
                return Obj.InstrumentsHistoryFolderGetAll(page,pageSize,ParentType,ChildType,Year,Month);

            }
            catch (Exception ex)
            {
                throw ex;
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
        public EList<InstrumentsHistoryFile> InstrumentsHistoryFileGetAll(int page, int pageSize, string Title, string CompanyName, string TabelName, int TableID)
        {
            try
            {
                InstrumentsHistoryFile Obj = new InstrumentsHistoryFile();
                Obj.SystemService = this;
                return Obj.InstrumentsHistoryFileGetAll(page, pageSize, Title, CompanyName, TabelName, TableID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 地区实体
        /// </summary>
        /// <param name="name">地区名称</param>
        /// <returns>实体</returns>
        public CompanyArea CompanyAreaGetOne(string name)
        {
            try
            {
                CompanyArea Obj = new CompanyArea();
                Obj.SystemService = this;
                return Obj.CompanyAreaGetOne(name);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 地区集合
        /// </summary>
        /// <returns>实体集合</returns>
        public EList<CompanyArea> CompanyAreaGetAll()
        {
            try
            {
                CompanyArea Obj = new CompanyArea();
                Obj.SystemService = this;
                return Obj.CompanyAreaGetAll();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取权力清单集合
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="pageSize">显示记录数</param>
        /// <param name="Name">权力名称</param>
        /// <param name="PowerType">权力类型</param>
        /// <returns>实体集合</returns>
        public EList<PowerInventory> PowerGetAll(int page, int pageSize, string Name, int PowerType)
        {
            try
            {
                PowerInventory Obj = new PowerInventory();
                Obj.SystemService = this;
                return Obj.PowerGetAll(page, pageSize, Name, PowerType);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取所有企业类型数据
        /// </summary>
        /// <returns>企业类型集合</returns>
        public List<CompanyType> CompanyTypeGetFastAll()
        {
            try
            {
                CompanyType Obj = new CompanyType();
                Obj.SystemService = this;
                return Obj.CompanyTypeGetFastAll();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
        public EList<Company> CompanyNewGetAll(int page, int pageSize, string name, int CompanyType, int CompanyArea, int IsCity)
        {
            try
            {
                Company Obj = new Company();
                Obj.SystemService = this;
                return Obj.CompanyNewGetAll(page, pageSize, name, CompanyType, CompanyArea, IsCity);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取公司信息结合
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        public EList<Company> CompanyGetAllByName(string name)
        {
            try
            {
                Company Obj = new Company();
                Obj.SystemService = this;
                return Obj.CompanyGetAllByName(name);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
