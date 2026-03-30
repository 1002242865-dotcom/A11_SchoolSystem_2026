using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    internal class ProgramTestsInAhleya
    {
        static void Main(string[] args)
        {

            B b1 = (B)new A(); //v x
            
            
            D d1 = new D();
            d1.H1();
            d1 = null;
            
            new D().H1(); //v v

            A a1 = new C();
            D d2 = (D)a1; //v x

            //(D)new C().H1(); //x

            ((D)new C()).H1();//v x 


        }
    }
}
