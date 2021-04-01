using graphqlmutationbasiccrud.Excep;
using graphqlmutationbasiccrud.IService;
using graphqlmutationbasiccrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud.Service
{
    public class StudentService : IStudentService
    {
        private IList<Student> _students;

        public StudentService()
        {
            _students = new List<Student>()
            {
                new Student(){StudentID=1,Name="Shikib",GroupId=1},
                new Student(){StudentID=2,Name="Rahat",GroupId=2},
                new Student(){StudentID=3,Name="Rohit",GroupId=3},
                new Student(){StudentID=4,Name="Arman",GroupId=1}
            };



        }
        public Student Create(CreateStudentInput inputStudent)
        {
            var student = new Student()
            {
                StudentID = _students.Max(x => x.StudentID) + 1,
                Name = inputStudent.Name,
                GroupId = inputStudent.GroupId
            };
            _students.Add(student);
            return student;
        }

        public Student Delete(DeleteStudentInput inputStudent)
        {
            var student = _students.FirstOrDefault(x => x.StudentID == inputStudent.StudentId);
            if (student==null)
                throw new StudentNotFoundExpection() { StudentId= inputStudent.StudentId};
            _students.Remove(student);
            return student;
        }

        public IQueryable<Student> GetAll()
        {
            return _students.AsQueryable();
        }
    }
}
