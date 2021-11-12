using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        // POST api/<ValuesController>
        [HttpPost]
        public ResponseType Post(PostRequest request)
        {
            string retVal = ManageRequest.runProcess(request);
            ResponseType response = new ResponseType();
            response.result = retVal;
            return response;
        }

    }
}
