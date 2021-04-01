using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
