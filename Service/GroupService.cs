using graphqlmutationbasiccrud.IService;
using graphqlmutationbasiccrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud.Service
{
    public class GroupService : IGroupService
    {
        private IList<Group> _groups;
        public GroupService()
        {
            _groups = new List<Group>() {
                new Group() { GroupId=1,Name="Science",ShortName="SC" },
                new Group() { GroupId=2,Name="Commerece",ShortName="COM" },
                new Group() { GroupId=1,Name="Arts",ShortName="AR" },

            };
        }
        public IQueryable<Group> GetAll()
        {
            return _groups.AsQueryable();
        }
    }
}
