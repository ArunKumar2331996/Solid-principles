using Dependency_inversion_principle.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dependency_inversion_principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadExampleController : ControllerBase
    {
        // This is a bad example coz we need to use interface in this case to achieve DI but we used actuall 
        // object which is a bad design.
        private EmployeeRepo _employeeRepo = null;
        public BadExampleController()
        {
            // Higher level module is tightly coupled with lower level which is not a good design.
            if (_employeeRepo == null)
            {
                _employeeRepo = new EmployeeRepo();
            }
        }

        [HttpGet]
        public List<EmployeeRepo> GetAllEmployee()
        {
            return _employeeRepo.GetAllEmployee();
        }
    }
}
