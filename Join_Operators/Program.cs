using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DepartmentClass> departments = new List<DepartmentClass>();
            departments.Add(new DepartmentClass { DepartmentID = 1, DepartmentName = "IT" });
            departments.Add(new DepartmentClass { DepartmentID = 2, DepartmentName = "Finance" });
            departments.Add(new DepartmentClass { DepartmentID = 3, DepartmentName = "Marketing" });

            List<EmployeeClass> employees = new List<EmployeeClass>();
            employees.Add(new EmployeeClass { DepartmentID = 1, EmployeeID = 1, EmployeeName = "Mel" });
            employees.Add(new EmployeeClass { DepartmentID = 2, EmployeeID = 2, EmployeeName = "Sheena" });
            employees.Add(new EmployeeClass { DepartmentID = 3, EmployeeID = 3, EmployeeName = "Nirmal" });


            var query = (from e in employees
                         join d in departments
                         on e.DepartmentID equals d.DepartmentID
                         select new {
                             e.EmployeeName,
                             d.DepartmentName
                         });

            foreach (var x in query)
            {
                Console.WriteLine($"Employee Name = {x.EmployeeName}, Department Name = {x.DepartmentName}");
            }
        }
    }

    public class DepartmentClass
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }

    public class EmployeeClass
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentID { get; set; }
    }
}
