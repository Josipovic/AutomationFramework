using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.TestCaseLogger
{
    public class TCLogger
    {
        private static string CurrentDirectory = Configuration.GetSettingsParameter("AutomationLogPath");
        private static string Filename = TestCaseData.TestCaseCode + "-" + TestCaseData.TestCaseName;
        private static string FilePath = CurrentDirectory + "/" + Filename + DateTimeOffset.Now.ToUnixTimeSeconds().ToString() + ".log";




        private void CheckIfDirectoryExists()
        {
            if (!Directory.Exists(CurrentDirectory))
                Directory.CreateDirectory(CurrentDirectory);
        }

        public static void Log(string Message, string ElementName)
        {

            using (StreamWriter w = File.AppendText(FilePath))
            {
                w.Write("{0}\t", ElementName);
                w.Write("{0}{1}", Message, Environment.NewLine);
                w.Flush();
            }
        }
    }
}
