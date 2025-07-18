using Demo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class User
    {
       public int Id { get; set; }
       //public bool[] Permissions { get; set; }= new bool[4];
       public Permissions Permission { get; set; }
    }
}
