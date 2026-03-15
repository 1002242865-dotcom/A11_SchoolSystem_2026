using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    internal class ProgramPolymorphzm
    {
        static void Main(string[] args)
        {
            //التحويل للاعلى המרה למעלה Upcasting (اب كاستينج)
            double x = 3;
            double y = (int)5; //زيادة 
           
            Object a1 = new Person();
            Object a2 = new Student(111, "ABC", 98, "054");
            Object a3 = new object();
            Object a4 = new Random();
           
            Object a5 = new D();

            Person p1 = new Worker();
            Object p2 = new Worker();

             

        }
    }
}
