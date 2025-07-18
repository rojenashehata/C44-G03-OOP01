using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    //derived class(child)
    internal class ClassB:ClassA
    {
        
       public ClassB() 
        {
            z = 9;
            y = 10;
            i = 9;
        }

        void method()
        {
            z = 9;
            y = 8;
            i = 8;
        }

    }
}
