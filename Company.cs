using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Company
    {
        private List<Department> Departments;
        private List<Employee> Employees;

        public Company()
        {
            Departments = new List<Department>();
            Employees = new List<Employee>();
        }

        public void AddDepartment(Department dept)
        {
            Departments.Add(dept);
            Console.WriteLine($" Department {dept.Name} has been added to the company.");
        }

        public void AddEmployee(Employee emp, string deptName)
        {
            var dept = Departments.Find(d => d.Name == deptName);
            if (dept != null)
            {
                dept.AddEmployee(emp);
                Employees.Add(emp);
            }
            else
            {
                Console.WriteLine(" Department not found.");
            }
        }
        public void GenerateReport()
        {
            Console.WriteLine("\n Employee Report:");
            foreach (var dept in Departments)
            {
                Console.WriteLine($"\n {dept.Name}");
                dept.ListEmployees();

            }
        }



    }
}
