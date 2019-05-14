using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Projmate.Api.Models
{
    public class Task : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 

    }

    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Complete,
        Canceld
    }
}
