using System;

namespace Interface_Segration_principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public Employee GetEmployee() => new Employee { EmpId=1, Name = "Test"};
        
    }

    public interface IEmployee
    {
        // General purpose interface is a problematic most of the time.
        Employee GetEmployee();
    
        // This employee Manager method is not associated with employee class so this can be created 
        // at a seperate interface.
        string GetEmployeeManager();


    }

    public interface IEmployeeManager {
        
        //Now whichever class is implementing this manager employee relation would implement this.
        string GetEmployeeManager();
    }
}
