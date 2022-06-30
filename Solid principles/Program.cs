using System;
using System.Collections.Generic;

namespace Solid_principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee employee = new Employee();
            var emp = employee.GetEmployees();
            foreach (var item in emp)
            {
                Console.WriteLine(item.EmpId);
            }
            
        }
    }

    public class Employee
    {
        public Employee()
        {
            //All the props and method inside the class should perform operations related to employee only.
        }
        public int EmpId { get; set; }

        public string Name { get; set; }

        // Returns the list of employee.
        public List<Employee> GetEmployees() => new List<Employee>() { new Employee { EmpId = 1, Name = "Test" } };

        //The GetAudit method here completeley violates the SRP principle. What we can do is, to implement this
        //particular method inside the Audit class.
        public Audit GetAudit() => new Audit { AuditId = 1, Name = "Sample" };
    }

    public class Audit {

        // Audit class follows SRP exactly.
        public int AuditId { get; set; }

        public string Name { get; set; }

        public Audit GetAudit() => new Audit { AuditId = 1, Name = "Sample" };

    }
}
