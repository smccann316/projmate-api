using Projmate.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projmate.Api.Services
{
    public interface IProjectService
    {
        Task<List<Project>> Get();
        Task<Project> Get(string id);
       
    }
}
