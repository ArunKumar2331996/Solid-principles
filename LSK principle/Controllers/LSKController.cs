using LSK_principle.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LSK_principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class LSKController : ControllerBase
    {
        private IEmployee _employee;

        public LSKController()
        {
            
        }

        [HttpGet]
        public Dictionary<string,object> GetBonusforAllEmployee()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            _employee = new ContractEmployee();            
            result.Add("Contract", _employee.Bonus());
            _employee = new PermanentEmployee();
            result.Add("Permanet",_employee.Bonus());

            //since we didn have bonus method for temporary worker we did like this rather throwing exception.
            // Other way is create a seperate interface for temporary employee class.
            result.Add("Temporary",null);
            return result;
            
        }
    }
}
