# SQL Script Execution

**Overview:**
	Command line program to run all SQL Server scripts in a directory.

**Requirements:**
	Windows only.
	The program requires the .Net Framework 4.8 or later. 
	Windows authentication is used for SQL Server. 
	No SQL Server edition specific features are used. All functions were tested using SQL Server 2017.
	Add the path to the sqlcmd.exe executable to the PATH environment variable, if not already added.

**Repository Contents:**
	Bin: The compiled executable.
	Source: Visual Studio solution with the C# source code
	ScriptTest: Scripts to run to test the program. The script in 04_Error will generate an error.
	
**Program Parameters:**
	1) The path to the scripts to be executed. All .sql files will be processed.
	2) The SQL Server instance name.
	3) The database name.
	
**Program Execution:**
	Scripts and directories will be run in alphabetical/numerical order. 
	Scripts in the root directory will be run before going into the directories.
	The program searches all directories under the specified starting directory.
	Depth First search - All scripts under directory A in root will be run before looking in directory B.
	The program will look for all .sql files, but any file with an extension that starts with sql will be included (ex .sqll).
	If a script causes an error, the error message will be displayed in the command window, execution will stop, and a file with the error message will be written.
	Scripts that use SQL Command mode can be used.

**Environment Variable:**
	On Windows 11:
	Search for env - select 'Edit the system environment variables' - Brings up 'System Properties'
	On 'Advanced' tab, click 'Environment Variables'.
	In 'System Variables' select 'Path' - Click Edit.
	My SQLCMD.exe is at: C:\Program Files\Microsoft SQL Server\Client SDK\ODBC\170\Tools\Binn (SQL Server 2022).
	If the path entry isn't there, click 'New' and create entry for path.
		