﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphqlmutationbasiccrud.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        public int GroupId { get; set; }
    }
}
