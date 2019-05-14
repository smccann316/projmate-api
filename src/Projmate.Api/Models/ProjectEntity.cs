using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projmate.Api.Models
{
    public class ProjectEntity : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public ProjectStatus Status { get; set; }
        
    }

    public enum ProjectStatus { NotStarted, InProgress, Complete, OnTrack, Late, Canceled }
}

