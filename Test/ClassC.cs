using Demo.UserDefinedDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class ClassC : ClassA
    {
        ClassC() 
        {
           // z = 7;// not accessible
            y = 9;//prtected attribut from ClassA on demo project which classC inherit from
       // i=9//not accessible => internal
        }
    }

    
}
