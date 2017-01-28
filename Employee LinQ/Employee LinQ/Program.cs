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
            List<Employee> employee = new List<Employee>(5);

            employee.Add(new Employee(1, 30000, 2));
            employee.Add(new Employee(2, 20000, 1));
            employee.Add(new Employee(3, 5000, 3));
            employee.Add(new Employee(4, 30000, 2));
            employee.Add(new Employee(5, 4000, 3));

            var Result = from value in employee
                         where value.Salary >= 10000
                         group value by value.Department into EmployeeGroup
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

