

DROP PROCEDURE IF EXISTS dbo.GetScriptExecutionTest;
GO
CREATE PROCEDURE dbo.GetScriptExecutionTest
AS

SELECT 
RecordId, DisplayName, ModifiedAt
FROM dbo.ScriptExecutionTest;

go
