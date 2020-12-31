using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID_Prinsiples.Single_Responsibility_Principle.Good
{
    public class Logger
    {
        public void LogFile(string filePath, string log)
        {
            File.WriteAllText(filePath, log);
        }

        public string BuildLog(string information)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Date : ");
            stringBuilder.Append(DateTime.Now.ToString());
            stringBuilder.AppendLine();
            stringBuilder.Append("Information : ").Append(information);

            return stringBuilder.ToString();
        }
    }
}
