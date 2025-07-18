using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    public class ClassA
    {
        //what you can write inside ?
        //1.Attribute => member  variable =>default private
        //int x;
        //2.Functions (Constructor,getter,setter,method)
        public ClassA()
        {

        }
        //3.proberty (full property, automatic prop, indexer)





        //////Access modifier allowed inside
        ////private : accissable only inside what declared on
        private int x;
        public void setx(int value)
        {
            x =value;
            y= value;
            z=value;
        }

        //protected //always related with inheritance
        protected int y;

        //private protected //known inside its class and another in the same project (assembly)
        private protected int z;

        //Internal //Internally inside its project //not outside its project

        internal int i = 9;

        //protected internal  : protected for which out its project ,
             //known inside its project and inside classes which out its project and inherit from
             //accessible inside<its project OR its child>
        protected internal int proIn = 10;


    }
}
