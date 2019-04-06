using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SQLScriptExecution
{
    public static class SQLScriptExecution
    {

        public static void SqlScriptExecution(
            string scriptDirectory,
            string instanceName,
            string databaseName
        )
        {
            var fileList = GetScriptNames(scriptDirectory);
            foreach(string filePath in fileList)
            {
                Console.WriteLine(filePath);
                RunScript(instanceName, databaseName, filePath);
            }

        }

        private static List<string> GetScriptNames(string scriptDirectory)
        {
            var fileList = Directory.GetFiles(scriptDirectory, "*.sql");
            List<string> returnList = fileList.ToList();
            return returnList;
        }

        private static void RunScript(
            string instanceName,
            string databaseName,
            string fileName
        )
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "sqlcmd.exe";
                process.StartInfo.Arguments = String.Format("-S {0} -d {1} -i {2} -b", instanceName, databaseName, fileName); 
                process.StartInfo.CreateNoWindow = true;
                // Required in order to read error message stream
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                process.WaitForExit();

                string error = process.StandardError.ReadToEnd();
                string output = process.StandardOutput.ReadToEnd();
                if (process.ExitCode != 0)
                {
                    if (error.Length == 0)
                    {
                        error = output; 
                    }
                    string errorMessage = "Error In Script: " + fileName + Environment.NewLine + "Error Message: " + error + Environment.NewLine;

                    throw new ApplicationException(errorMessage);
                }
                
            }
        }

    }
}
