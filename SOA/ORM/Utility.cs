using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NBearLite;
using Common;
using System.Data;

namespace SOA.ORM
{
    public static class Utility
    {
        public static void UpdateStatus(int id, string tableName, string fileName,string title,  int archiveId, IQueryTable toTable, QueryColumn toStatus, QueryColumn toPrimary)
        {
            NBearLite.DbProviders.DbProvider provider =
                        NBearLite.DbProviders.DbProviderFactory.CreateDbProvider(
                                null,
                                "System.Data.SqlServerCe",
                                @"Data Source=enforce.sdf;
                                  Encrypt Database=True;
                                  Password=enforce_123456;
                                  File Mode=shared read;
                                  Persist Security Info=False;");
            Database database = new Database(provider);

            UpdateSqlSection section = new UpdateSqlSection(database, toTable);
            section.AddColumn(toStatus, 2); // 2 代表已归档
            section.Where(toPrimary == id);
            section.Execute();

            InsertSqlSection insert = new InsertSqlSection(database, DataBases.ArchiveExt);
            insert.AddColumn(DataBases.ArchiveExt.ArchiveID, archiveId);
            insert.AddColumn(DataBases.ArchiveExt.TableName, tableName);
            insert.AddColumn(DataBases.ArchiveExt.PrimaryValue, id);
            insert.AddColumn(DataBases.ArchiveExt.FileName, fileName);
            insert.AddColumn(DataBases.ArchiveExt.Title, title);
            insert.AddColumn(DataBases.ArchiveExt.CreateTime, DateTime.Now);
            insert.AddColumn(DataBases.ArchiveExt.ExchangeGUID, CommonInvoke.NewGuid);
            insert.Execute();
        }

        public static DataSet GetArchiveExtByArchiveId(int id) {
            NBearLite.DbProviders.DbProvider provider =
                        NBearLite.DbProviders.DbProviderFactory.CreateDbProvider(
                                null,
                                "System.Data.SqlServerCe",
                                @"Data Source=enforce.sdf;
                                  Encrypt Database=True;
                                  Password=enforce_123456;
                                  File Mode=shared read;
                                  Persist Security Info=False;");
            Database database = new Database(provider);
            SelectSqlSection section = database.Select(DataBases.ArchiveExt).Where(DataBases.ArchiveExt.ArchiveID == id);
            DataSet ds = section.ToDataSet();

            return ds;
        }

        /// <summary>
        /// 生成文档存放目录，目录以“/”符号结尾。
        /// </summary>
        /// <returns></returns>
        public static string GetFileSavePath() {
            string folder = DateTime.Now.ToString("yyyy/");
            string root = "archives/";
            string path = root + folder;

            return path;
        }

        /// <summary>
        /// 生成后缀为doc的文件名。
        /// </summary>
        /// <returns></returns>
        public static string BuilderFileName() {
            string fileName = CommonInvoke.NewGuid + ".rtf";
            return fileName;
        }
    }
}
