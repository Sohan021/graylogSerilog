using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GralogSeriLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
                
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var values = new string[] { "value1", "value2" };
            //_logger.LogInformation("Retrieving values", values);
            return values;
        }
    }
}
