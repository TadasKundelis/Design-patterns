using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    interface IEmployee
    {
        string Name { get; set; }
        string Department { get; set; }
        List<Employee> Subordinates { get; set; }
    }
    class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<Employee> Subordinates { get; set; }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
            Subordinates = new List<Employee>();
        }

        public void AddSubordinate(Employee employee)
        {
            Subordinates.Add(employee);
        }

        public void RemoveSubordinate(Employee employee)
        {
            Subordinates.Remove(employee);
        }

        public List<Employee> GetSubordinates()
        {
            return Subordinates;
        }

        public void GetDetails(int indentation = 0)
        {
            string dashes = new String('-', indentation);
            Console.WriteLine("{0}Employee name: {1}, works in department: {2}", dashes, Name, Department);
        }

        public void GetSubordinateDetails()
        {
            Console.WriteLine("{0}'s subordinates", Name);
            foreach(Employee employee in Subordinates)
            {
                employee.GetDetails(indentation: 2);
            }
        }
    }
}
