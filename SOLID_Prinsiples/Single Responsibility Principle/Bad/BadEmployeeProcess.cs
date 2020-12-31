using SOLID_Prinsiples.Single_Responsibility_Principle.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID_Prinsiples.Single_Responsibility_Principle.Bad
{
    public class BadEmployeeProcess
    {
        public void InsertEmployee(Employee newEmployee)
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                //Employe Insertion Process
                stringBuilder.Append(newEmployee.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(newEmployee.FirstName);
                stringBuilder.AppendLine();
                stringBuilder.Append(newEmployee.LastName);
                File.WriteAllText(@"C:\EmployeeData.txt",
                    stringBuilder.ToString());

                // Keeping logs of the employee insertion process

                stringBuilder = new StringBuilder();
                stringBuilder.Append("Logging Insertion Date");
                stringBuilder.Append(DateTime.Now.ToString());
                stringBuilder.AppendLine();
                stringBuilder.Append("Personal ID : ");
                stringBuilder.Append(newEmployee.Id);
                File.WriteAllText(@"C:\Log.txt", stringBuilder.ToString());
            }
            catch (Exception ex)
            {
                // If an error is received in the insertion process, the process of keeping error records.
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Error Date : ");
                stringBuilder.Append(DateTime.Now.ToString());
                stringBuilder.AppendLine();
                stringBuilder.Append("Error Message : ");
                stringBuilder.Append(ex.Message);
                File.WriteAllText(@"C:\Log.txt", stringBuilder.ToString());
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}
