using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud.Excep
{
    public class StudentNotFoundExpection:Exception
    {
        public int StudentId { get; internal set; }
    }
}
