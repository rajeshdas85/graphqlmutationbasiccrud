using graphqlmutationbasiccrud.IService;
using graphqlmutationbasiccrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud.GraphQL
{
    public class Mutation
    {
        private readonly IStudentService _studentService;
        public Mutation(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public Student CreateStudent(CreateStudentInput inputStudent)
        {
            return _studentService.Create(inputStudent);
        }
        public Student DeleteStudent(DeleteStudentInput inputStudent)
        {
            return _studentService.Delete(inputStudent);
        }
    }
}
