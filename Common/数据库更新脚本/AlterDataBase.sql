/*
   2013年3月4日15:42:24
   用户: 林楠
   表名：
   列名：
   说明: 
*/

--if(not exists(select b.name from sysobjects a,syscolumns b where a.id = b.id and b.name = 'customize_id' and a.name='cs_bank'))
--begin 

--ALTER TABLE dbo.cs_bank ADD
--	customize_id varchar(50) NOT NULL CONSTRAINT DF_cs_bank_customize_id DEFAULT ''
--end
--GO

-- 执法档案
-- Script Date: 2013/4/26 11:51  - ErikEJ.SqlCeScripting version 3.5.2.26
DROP TABLE [Archive];
GO
CREATE TABLE [Archive] (
  [guid] nchar(32) NOT NULL
, [tableName] nvarchar(50) NULL
, [primaryValue] int NOT NULL
, [name] nvarchar(200) NOT NULL
, [creationDate] datetime NOT NULL
, [alias] nvarchar(200) NOT NULL
, [fileName] nvarchar(500) NOT NULL
, [exchangeGUID] nchar(32) NOT NULL
);
GO
ALTER TABLE [Archive] ADD CONSTRAINT [PK_ARCHIVE] PRIMARY KEY ([guid]);
GO