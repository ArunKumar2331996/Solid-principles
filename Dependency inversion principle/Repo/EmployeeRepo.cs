using System.Collections.Generic;

namespace Dependency_inversion_principle.Repo
{
    public class EmployeeRepo: IEmployeeRepo
    {
        public int EmpId { get; set; }
        public string  Empname { get; set; }

        private List<EmployeeRepo> GetEmpList()
        {
            return new List<EmployeeRepo>() { new EmployeeRepo { EmpId=1,Empname="Test1"},
            new EmployeeRepo{ EmpId=2,Empname="Test2"} };
        }

        public List<EmployeeRepo> GetAllEmployee() => GetEmpList();
        public EmployeeRepo GetEmployeeById(int id) => GetEmpList().Find(x=>x.EmpId==id);
    }

    public interface IEmployeeRepo {
        List<EmployeeRepo> GetAllEmployee();
        EmployeeRepo GetEmployeeById(int id);
    }
}
