using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    internal class ProgramVirtualOverride
    {
        static void Main4(string[] args)
        {
           Person p1=new Person(100,"ABCD");
            p1.G3();

            Student st1=new Student(111, "ABC", 98, "054");
            st1.G3();

            //string str = "Welcome: " + p1;
            //Console.WriteLine(p1);

            //Person p2 = null;
            //Console.WriteLine(p2); //null
            //Console.WriteLine(p2.ToString());
        }
    }
}
