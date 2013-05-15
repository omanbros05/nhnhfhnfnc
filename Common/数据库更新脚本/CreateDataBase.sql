/*
   2013年3月4日15:42:24
   用户: 林楠
   表名：TableSequence
   说明: 新增表TableSequence
*/
if (not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TableSequence]') and OBJECTPROPERTY(id,N'IsUserTable') = 1))
begin
create table [dbo].[TableSequence]
    (
      [TableName] [nvarchar](200) not null,
      [Sequence] [int] not null,
      constraint [PK_TableSequence] primary key clustered ( [TableName] asc )
        with ( pad_index = off, statistics_norecompute = off,
               ignore_dup_key = off, allow_row_locks = on,
               allow_page_locks = on ) on [PRIMARY]
    )
on  [PRIMARY]

end

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'表名',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'TableSequence', @level2type = N'COLUMN',
    @level2name = N'TableName'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'序列',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'TableSequence', @level2type = N'COLUMN',
    @level2name = N'Sequence'
GO


/*
   2013年3月6日15:42:24
   用户: 林楠
   表名：Company
   说明: 新增表Company
*/
if (not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Company]') and OBJECTPROPERTY(id,N'IsUserTable') = 1))
begin
create table [dbo].[Company]
    (
      [CompanyID] [int] not null,
      [CompanyName] [nvarchar](500) not null,
      [CompanyAddress] [nvarchar](1000) not null,
      [CompanyPost] [nvarchar](50) not null,
      [JuridicalPerson] [nvarchar](500) not null,
      [JuridicalPersonSex] [nvarchar](50) not null,
      [JuridicalPersonAge] [int] not null,
      [JuridicalPersonJob] [nvarchar](50) not null,
      [Mobile] [nvarchar](100) not null,
      [Tel] [nvarchar](100) not null,
      constraint [PK_Company] primary key clustered ( [CompanyID] asc )
        with ( pad_index = off, statistics_norecompute = off,
               ignore_dup_key = off, allow_row_locks = on,
               allow_page_locks = on ) on [PRIMARY]
    )
on  [PRIMARY]
end

GO
exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'企业自动编号',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'CompanyID'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'企业名称',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'CompanyName'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'企业地址',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'CompanyAddress'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'企业邮编',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'CompanyPost'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'法人/负责人',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'JuridicalPerson'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'法人性别',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'JuridicalPersonSex'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'法人年龄',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'JuridicalPersonAge'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description', @value = N'法人职务',
    @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE',
    @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'JuridicalPersonJob'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description',
    @value = N'联系方式(手机)', @level0type = N'SCHEMA', @level0name = N'dbo',
    @level1type = N'TABLE', @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'Mobile'
GO

exec sys.sp_addextendedproperty @name = N'MS_Description',
    @value = N'联系方式(电话)', @level0type = N'SCHEMA', @level0name = N'dbo',
    @level1type = N'TABLE', @level1name = N'Company', @level2type = N'COLUMN',
    @level2name = N'Tel'
GO