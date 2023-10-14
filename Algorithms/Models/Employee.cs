using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Models
{
    public class Employee: IComparable<Employee>
    {
        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {     
            return SortAscending(other);
            // return SortDescending(other);
        }

        private int SortAscending(Employee other)
        {
            // ascending order
            //return this.Salary.CompareTo(other.Salary);
            if (other.Salary < this.Salary)
            {
                return 1;
            }
            else if (other.Salary > this.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private int SortDescending(Employee other)
        {
            //return other.Salary.CompareTo(this.Salary);
            if (this.Salary < other.Salary)
            {
                return 1;
            }
            else if (this.Salary > other.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    
        public static void TestSorting()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Employee Sorting tests");
            Console.WriteLine("***********************************");

            var employees = new List<Employee>
            {
                new Employee("John Doe", 1230),
                new Employee("Lucy Novak", 670),
                new Employee("Robin Brown",2300),
                new Employee("Joe Draker", 1190),
                new Employee("Janet Doe", 980)
            };

            employees.Sort();
            employees.ForEach(employee => Console.WriteLine(employee.Salary));
            Console.WriteLine("---------------------------");

            employees.Reverse();
            employees.ForEach(employee => Console.WriteLine(employee.Salary));
            Console.WriteLine("---------------------------");
        }
    }
}
