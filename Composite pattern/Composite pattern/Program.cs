using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee CEO = new Employee("Mike Laurey", "CEO");
            Employee headOfHr = new Employee("John Smiths", "HR");
            Employee headOfManagement = new Employee("Mark Williams", "Management");
            Employee recruiter = new Employee("Peter Ebdon", "HR");
            Employee recruiter2 = new Employee("Shaun Murphy", "HR");
            Employee manager = new Employee("Alice Dundis", "Management");
            Employee manager2 = new Employee("Monica Belucci", "Management");

            CEO.AddSubordinate(headOfHr);
            CEO.AddSubordinate(headOfManagement);

            headOfHr.AddSubordinate(recruiter);
            headOfHr.AddSubordinate(recruiter2);

            headOfManagement.AddSubordinate(manager);
            headOfManagement.AddSubordinate(manager2);

            CEO.GetDetails();
            CEO.GetSubordinateDetails();
            headOfHr.GetDetails();
            headOfHr.GetSubordinateDetails();
            headOfManagement.GetDetails();
            headOfManagement.GetSubordinateDetails();
            recruiter.GetDetails();
            manager.GetDetails();

            Console.ReadKey();
        }
    }
}
