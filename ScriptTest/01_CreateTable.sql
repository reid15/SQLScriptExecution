

DROP TABLE IF EXISTS dbo.ScriptExecutionTest;

CREATE TABLE dbo.ScriptExecutionTest(
RecordId int not null identity(1,1),
DisplayName varchar(20) not null,
ModifiedAt datetime2 not null default getdate()
);

go