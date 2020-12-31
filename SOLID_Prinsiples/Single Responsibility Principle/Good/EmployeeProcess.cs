using SOLID_Prinsiples.Single_Responsibility_Principle.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Single_Responsibility_Principle.Good
{
    public class EmployeeProcess
    {
        Logger logger;
        string log;

        public EmployeeProcess()
        {
            logger = new Logger();
        }
        public bool InsertEmployee(Employee employee)
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                stringBuilder.Append(employee.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.FirstName);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.LastName);

                log = logger.BuildLog(stringBuilder.ToString());
                logger.LogFile(@"C:\Log.txt", log);

                log = logger.BuildLog("Employee Insert Succesfull : " + employee.Id);
                logger.LogFile(@"C:\Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {
                log = logger.BuildLog("Error Message : " + ex.Message);
                logger.LogFile(@"C:\Log.txt", log);

                return false;
            }
        }
    }
}
