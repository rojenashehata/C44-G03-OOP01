using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Enums
{
    //flags mean true or false
    [Flags] //attribute
    public enum Permissions:byte //8 bit
    {
        Delete=1,//0001 1
        Excute=2,//0010  2
        Read=4, //0100 4
        Write=8  //1000  8

        // 1+2=3 //0001+0010=0011 //3
    }
}
