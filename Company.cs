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
            TopPerformers.Clear();
            foreach(Employee emp in Employees)
            {
                double averageRating = emp.PerformanceRatings.Count > 0 ? emp.PerformanceRatings.Average() : 0;
                if(averageRating >= 9)
                {
                    TopPerformers.Add(emp);
                }
            }
        public void GenerateReport()
        {
            Console.WriteLine($"\nCompany Report: {Name}");
            Console.WriteLine("--------------------------");
        }
            foreach(Department dep in Departments)
            {
                Console.WriteLine($"Department: {dep.Name}");
                dep.ListEmployees();
                Console.WriteLine("-----------------------");
            }

            if (TopPerformers.Count == 0)
            {
                Console.WriteLine("No top performers found");
            }
            else
            {
                Console.WriteLine("Top Performers: ");
                foreach (Employee emp in TopPerformers)
                {
                    double avgRating = emp.PerformanceRatings.Count > 0 ? emp.PerformanceRatings.Average() : 0;
                    Console.WriteLine($"{emp.Name} Avg Rating: {avgRating}");
                }
            }
        }



    }
}
