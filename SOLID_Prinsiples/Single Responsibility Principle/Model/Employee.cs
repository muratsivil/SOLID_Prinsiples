using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Single_Responsibility_Principle.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
    }
}
