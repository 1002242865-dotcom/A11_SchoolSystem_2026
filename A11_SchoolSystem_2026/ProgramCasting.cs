using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    internal class ProgramCasting
    {
        static void Main8(string[] args)
        {
            //upcasting ولا يتطلب كتابة تحويل خاص- بشكل صريح وهو دائما صحيح
            //D d1= new D();
            //C c1 = new D();
            //A a1 = new D();
            //Object o1 = new D();
            //B b1 = new D(); ///خطـأ ترجمة وتحويل

            //d1.F2(); //يتم تنفيذ العملية الموجودة في الفئة A
            //d1.F3(); // يتم تنفيذ العملية الموجودة في الفئة C لانها قامت باعادة تطبيق العملية override
            //a1.F2();
            //a1.F3();

            //Console.WriteLine(o1.ToString());

            //D d1 = new D();
            //C c1 = d1;
            ////B b1 = d1;// خطأ ترجمة وتحويل
            //A a1 = d1;
            //Object o1 = d1;

            //c1.F2();


            D d1 = new D();
            C c1 = d1;
            A a1 = c1;



            A[] arr = new A[6];
            arr[0] = new A();
            arr[1] = new B();
            arr[2] = new C();
            arr[3] = new D();
            arr[4] = new B();
            arr[5] = arr[2];

            
            for(int i=0;i<arr.Length;i++)
            {
                //arr[i].F2();
                arr[i].F3();
                
                    
            }

            



        }
    }
}
