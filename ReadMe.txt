SQL Script Execution

Overview:
	Command line program to run all SQL Server scripts in a directory.

Requirements:
	Windows only.
	The program requires the .Net Framework 4.8 or later. 
	Windows authentication is used for SQL Server. 
	No SQL Server edition specific features are used. All functions were tested using SQL Server 2017.
	Add the path to the sqlcmd.exe executable to the PATH environment variable.

Repository Contents:
	Bin: The compiled executable.
	Source: Visual Studio solution with the C# source code
	ScriptTest: Scripts to run to test the program. The 03_Error.sql script will generate an error.
	
Program Parameters:	
	1) The path to the scripts to be executed. All .sql files will be processed.
	2) The SQL Server instance name.
	3) The database name.
	
Program Execution:
	Scripts and directories will be run in alphabetical/numerical order. 
	Scripts in the root directory will be run before going into the directories.
	The program search all directories under the specified starting directory.
	The program will look for all .sql files, but any file with an extension that starts with sql will be included (ex .sqll).
