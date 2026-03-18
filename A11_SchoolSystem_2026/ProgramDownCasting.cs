using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    internal class ProgramDownCasting
    {
        static void Main(string[] args)
        {
            //down casting التحويل للاسفل המרה למטה
            //كما تعلمنا ساباق فان نوع المؤشر يحدد ماهي العمليات التي نستطيع استدعائها (ترجمة وتحويل)
            //ونوع الكائن هو الذي يحدد ماهي العمليات التي يتم تنفيذها (تنفيذ)ي يحدد اي نسخة من العملية يتم تنفيذها(خاصة اذا قمنا ب override)
            //وكذلك دائما صحيح وضع مؤشر من نوعية الاب/الجد....وصولا حتى object 
            //
            //الى كائن من نوع الابن/الحفيد....الخ

            //D d1 = new A();
            //B b1 = new A();
            //C c1=new A();
            //D d1 = new C();

            A a1 = new A(); // v v 
            B b1 = (B)a1; // v x

            A a2 = new B(); // v v
            B b2 = (B)a2; // v v


            A a3 = new C(); // v v
            C c3 = (C)a3; // v  v

            A a4 = new D(); // v v 
            C c4 = (C)a4;
            
            
            C c44 = (D)a4;





            //int x = (int)9.8;
            //double a = 100.99;
            //int b = (int)a;

            //C c11 = new D();//upcasting


        }
    }
}
