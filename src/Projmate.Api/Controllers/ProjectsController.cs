using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projmate.Api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet(Name =nameof(GetProjects))]
        public IActionResult GetProjects()
        {
            throw new NotImplementedException();
        }
    }
}