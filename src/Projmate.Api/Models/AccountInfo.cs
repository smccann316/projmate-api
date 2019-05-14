using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projmate.Api.Models
{
    public class AccountInfo : Resource
    {
        public string Name { get; set; }
        public string Emnail { get; set; }
        public string Description { get; set; }
        public int NumberOfUsers { get; set; }

    }
}
