:setvar insertValue "Record6"

INSERT INTO dbo.ScriptExecutionTest(DisplayName) VALUES ('$(insertValue)');
