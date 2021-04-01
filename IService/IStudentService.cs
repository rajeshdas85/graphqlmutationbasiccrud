using graphqlmutationbasiccrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud.IService
{
   public interface IStudentService
    {
        IQueryable<Student> GetAll();
        Student Create(CreateStudentInput inputStudent);
        Student Delete(DeleteStudentInput inputStudent);
    }
}
