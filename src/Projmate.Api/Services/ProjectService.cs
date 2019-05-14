
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projmate.Api.Models;
using Microsoft.Extensions.Configuration;
using AutoMapper;

namespace Projmate.Api.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IMongoCollection<ProjectEntity> _projects;
        private readonly IMapper _mapper;
        public ProjectService(IConfiguration config, IMapper mapper)
        {
            _mapper = mapper;
            var client = new MongoClient(config.GetConnectionString("ProjMate"));
            var dataabase = client.GetDatabase(config.GetSection("DbName").Value);
            _projects = dataabase.GetCollection<ProjectEntity>("Projects");
        }

        public async Task<List<Project>> Get()
        {
            throw new NotImplementedException();
            //var entity =  await _projects.Find(Project => true)
            //    .ToListAsync();

        }

        public async Task<Project> Get(string id)
        {
            var entity = await _projects.Find(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<Project>(entity);
        }

    }
}
