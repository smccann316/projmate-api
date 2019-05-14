using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projmate.Api.Models;
using Projmate.Api.Services;

namespace Projmate.Api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _service;
        public ProjectsController(IProjectService service)
        {
            _service = service;
        }
        [HttpGet(Name = nameof(GetProjects))]
        public IActionResult GetProjects()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name =nameof(GetProjectById))]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async  Task<ActionResult<Project>>GetProjectById(string id)
        {
            var resource =  await _service.Get(id);
            if (resource == null)
                return NotFound();
            return resource;

        }
    }
}