using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    internal class ProgramMethods
    {
        static void Main3(string[] args)
        {
            //Student st1 = new Student(111, "ABC", 98, "054");
            // Console.WriteLine("st1.Phone:" + st1.Phone);
            //Person p1 = st1; //تعدد صوري UpCasting
            //Console.WriteLine("p1.Phone:" + p1.Phone);

           // Person p9 = new Student(1,"yty",99,true);

            Person p1 = new Person(100, "ABCD");
            Console.WriteLine(p1.GetId());

            Student st2 = new Student(888, "WWW", 98, "0542222");
            st2.PrintDetails();
            Console.WriteLine(st2.GetId());


            Student st3 = new Student(1, "Watan", 100, "05055555");
            st3.PrintDetails(); //v اضافها
            st3.TestMethod();  //v اضافها
            st3.GetId(); // v ورثها
            //st3.G2(); //x على الرغم انه ورثها ولكنها protected
            //st3.G1(); //x على الرغم انه ورثها ولكنها private

            

            //st1.PrintDetails(); 

            //التعدد الصوري Polymorphism רב צורתיות
        }
    }
}
