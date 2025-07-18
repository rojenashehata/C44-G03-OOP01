using Demo.Enums;
using Demo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }

        public Grades Grade { get; set; }

        public Branch Branch { get; set; }
    }
}
