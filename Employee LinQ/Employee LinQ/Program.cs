using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_LinQ
{
    class Employee
    {
        public int EmployeeID;
        public int Salary;
        public int Department;

        public Employee(int ID, int salary, int department)
        {
            EmployeeID = ID;
            Salary = salary;
            Department = department;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(5);

            employees.Add(new Employee(1, 30000, 2));
            employees.Add(new Employee(2, 20000, 1));
            employees.Add(new Employee(3, 5000, 3));
            employees.Add(new Employee(4, 30000, 2));
            employees.Add(new Employee(5, 4000, 3));

            var Result = from employee in employees
                         where employee.Salary >= 10000
                         group employee by employee.Department into EmployeeGroup
                         select new
                         {
                             count = EmployeeGroup.Count(),
                             key = EmployeeGroup.Key
                         };
            
            foreach (var Answer in Result)
                Console.WriteLine(Answer);
            Console.ReadKey();
        }
    }
}

