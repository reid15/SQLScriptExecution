using System;
using System.IO;

namespace SQLScriptExecution
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting SqlScriptExecution");
                SQLScriptExecution.SqlScriptExecution(args[0], args[1], args[2]);
                Console.WriteLine("Ending SqlScriptExecution");
            }
            catch (Exception e)
            {
                ErrorHandler(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static void ErrorHandler(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            string fileName = "Error" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            File.WriteAllText(fileName, errorMessage);
        }
    }
}
