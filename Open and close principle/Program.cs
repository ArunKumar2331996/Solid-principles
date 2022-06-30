using System;

namespace Open_and_close_principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.GetEmployeeId());
        }
    }

    public class Employee
    {
        // When we intially create this class with a property EmpId which is an integer.
        // Based on this we are creating database table employee with column EmployeeId which is an integer again.
        // This change successfully went to production and it has unit test coverage of 100%

        //If in case in future the change proposed to empid can be alpha numeric in that situation we cant 
        //simply change the data type which will affect all our existing rather we can extend this employee
        //and derive our output.
        public int EmpId { get; set; } = 1;

        public int GetEmployeeId()=> EmpId;
    }

    public class EmployeeExtended: Employee
    {
        // we created a subset class and we didn modified anything in the base class.
        public new string EmpId { get; set; }
    }
}
