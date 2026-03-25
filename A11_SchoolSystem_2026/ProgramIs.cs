using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    internal class ProgramIs
    {
        static void Main(string[] args)
        {
            A a = new D();//upcasting اب كاستينج
            RunH1(a);

            //اما عند استدعائها على النحو التالي، سيحدث خطأ زمن تشغيل
            A a2 = new A();
            RunH1(a2);


            A a3 = new B();
            RunH1(a3);
            
            A a4=new C();     
            RunH1(a4);
            //عند محاولة النظر الى الكائنات التي تشير اليها a2,a3,a4 بنظرة 
            //D فان ذلك التحويل سيفشل
        }
        //أكتب عملية خارجية باسم RunH1
        //التي تتلقى مؤشر من نوعية A
        //وتقوم باستدعاء العملية H1 من خلال هذا المؤشر
        //حيثما أمكن
        public static void RunH1(A a1)
        {
            //a1.H1(); // x
            //a1.F1(); // v v 
            //a1.F2();// v v 
            //a1.F3();// v v             
            //D d1 = (D)a1; //التحويل للاسفل يجب ان يكون بشكل صريح
            //// v    v/x نجاح زمن التشغيل متعلق بنوع الكائن
            //d1.H1();

            if(a1 is D)
            {
                a1.G1(); //خطأ شائع
                D d1 = (D)a1;
                d1.H1();
                
                //كتابات مختصرة
            }
            
        }

        //أكتب عملية خارجية باسم RunG1
        //التي تتلقى مؤشر من نوعية A
        //وتقوم باستدعاء العملية G1 
        //حيثما أمكن

        public static void RunG1(A a1)
        {
            //if(a1 is D) //هل الكائن من نوعية D، هل الكائن الذي يشير اليه a1
            //    //يتقبل / يتحمل مؤشر من نوعية D
            //{
            //    D d1 = (D)a1;
            //    d1.G1();
            //}

            if (a1 is C) // ستكون النتيجة صدق اذا كان الكائن الذي يشير اليه a1
                //من نوعية D or C
            {
                //a1.G1(); //خطأ شائع
                C c1 = (C)a1;
                c1.G1();
            }
            //او 
            if (a1 is C || a1 is D) // ستكون النتيجة صدق اذا كان الكائن الذي يشير اليه a1
                         //من نوعية D or C
            {
                C c1 = (C)a1;
                c1.G1();
            }
        }
    }
}
