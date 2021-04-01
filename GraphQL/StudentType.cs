﻿using graphqlmutationbasiccrud.IService;
using graphqlmutationbasiccrud.Models;
using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud.GraphQL
{
    public class StudentType:ObjectType<Student>
    {
        protected override void Configure(IObjectTypeDescriptor<Student> descriptor)
        {
           
            descriptor.Field(x => x.Name).Type<StringType>();
            descriptor.Field(x => x.StudentID).Type<IdType>();
            descriptor.Field<GroupResolver>(x => x.GetGroup(default, default));
        }
        public class GroupResolver
        {
            private readonly IGroupService _groupService;
            public GroupResolver([Service] IGroupService groupService)
            {
                _groupService = groupService;
            }
            public Group GetGroup(Student student, IResolverContext ctx)
            {
                return _groupService.GetAll().Where(x => x.GroupId == student.StudentID).FirstOrDefault();
            }
        }
    }
}
