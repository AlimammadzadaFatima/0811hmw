using System;
using System.Collections.Generic;
using System.Text;

namespace _0811hmw
{
    class Student
    { public Student()
        {
            sttcount += 1;
            No = sttcount;
        }
        public int No;
       public string Fullname;
        public static int sttcount;
        
    }
}
