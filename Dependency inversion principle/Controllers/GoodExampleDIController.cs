using Dependency_inversion_principle.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dependency_inversion_principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodExampleDIController : ControllerBase
    {
        //Here the higher level is less coupled with lower level module.
        // we used dependency injection here to achieve dependency inversion principle.
        // constructor injection in used here and the DI registration is done in startup class.
        private readonly IEmployeeRepo _employeeRepo;
        public GoodExampleDIController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public List<EmployeeRepo> GetAllEmployee()
        {
            return _employeeRepo.GetAllEmployee();
        }
    }
}
