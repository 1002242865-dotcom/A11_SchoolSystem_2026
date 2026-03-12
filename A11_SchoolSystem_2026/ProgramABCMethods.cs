using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    internal class ProgramABCMethods
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.F1(); 
            a1.F2();
            a1.F3();
            Console.WriteLine(a1);

            Console.WriteLine();

            B b1 = new B();
            b1.F1(); //سيتم استدعاء العملية F1 من فئة الاب A لانه لم يتم اعادة تعريفها في فئة الابن B
            b1.F2(); //سيتم استدعاء العملية F2 من فئة الابن B لانه تم اعادة تطبيقها في فئة الابن B باستخدام الكلمة override
            b1.F3(); //سيتم استدعاء العملية F3 من فئة الاب A لانه لم يتم اعادة تطبيقها في فئة الابن B، وبالتالي سيتم استخدام العملية F3 الموروثة من فئة الاب A
            Console.WriteLine(b1); // سيتم استدعاء العملية ToString من فئة الابن B لانه تم اعادة تطبيقها في فئة الابن B باستخدام الكلمة override، وبالتالي سيتم استخدام العملية ToString المطبقة في فئة الابن B


            Console.WriteLine();

            C c1 = new C();
            c1.F1(); //A
            c1.F2(); //A
            c1.F3(); //C
            c1.G1(); //C
            Console.WriteLine(c1); //A


            Console.WriteLine();
            D d1=new D();
            d1.F1(); //A
            d1.F2(); //A
            d1.F3(); //C
            d1.G1(); //C
            d1.H1(); //D
            Console.WriteLine(d1); //A

            

        }
    }

    class D : C
    {
        public void H1()
        {
            Console.WriteLine("A--> F2");
        }
    }

    

    class A
    {
        public void F1()
        {
            Console.WriteLine("A--> F1");
        }
        public virtual void F2()
        {
            Console.WriteLine("A--> F2");
        }
        public virtual void F3()
        {
            Console.WriteLine("A--> F3");
        }
        public override string ToString()
        {
            return "A--> ToString";
        }
    }

    class B : A
    {
        public override void F2()
        {
            Console.WriteLine("B--> F2");
        }
        public override string ToString()
        {
            return "B--> ToString";
        }
    }
    class C: A
    {       
        public override void F3()
        {
            Console.WriteLine("C--> F3");
        }
        public void G1()
        {
            Console.WriteLine("C--> G1");
        }
    }

    


}
