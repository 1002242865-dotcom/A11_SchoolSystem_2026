using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    class Student : Person
    {

        private int Avg;
        public string Phone;
       

        public Student(int Id,string Name,int Avg,string phone):base(Id,Name)
        { 
            this.Avg = Avg;
            this.Phone = phone;
            Console.WriteLine("Student");

        }

        public void PrintDetails()
        {
            //Console.WriteLine("Esm:"+Name+", Year:");
            Console.WriteLine("this.Phone:"+ this.Phone); //هنا يتم استدعاء المتغير الذي تم تعريفه في فئة الابن
            Console.WriteLine("base.Phone:" + base.Phone); // هنا يتم استدعاء المتغير الذي تم تعريفه في فئة الاب، ولكن في الحقيقة هذا المتغير لا يحتوي على اي قيمة لانه لم يتم تهيئته في فئة الاب، وبالتالي ستكون قيمته null
            Console.WriteLine("Phone:" + Phone); // هنا يتم استدعاء المتغير الذي تم تعريفه في فئة الابن، ولكن بدون كتابة الكلمة this، وبالتالي سيتم البحث عن المتغير في فئة الابن اولا، وعندما لا يتم العثور عليه سيتم البحث عنه في فئة الاب، ولكن في الحقيقة هذا المتغير لا يحتوي على اي قيمة لانه لم يتم تهيئته في فئة الاب، وبالتالي ستكون قيمته null
            //this.Id

           
        }


        //داخل فئة الابن نستطيع استدعاء العمليات التي ورثناها من فئة الاب بشرط ان تكون 
        //public / protected
        //private ما بزبط
        public void TestMethod()
        {
            base.GetId();
            this.GetId();
            GetId();

            base.G2();
            this.G2();
            G2();
        }

        //دائما يتم استدعاء عملية البناء في فئة الاب قبل فئة الابن
        //ويكون ذلك اما بشكل صريح كما هو الحال في المثال السابق
        //:base(Id,Name)
        //واما بشكل غير صريح(بدون كتابة الكلمة base)
        // ويكون ذلك صحيح فقط عندما تحتوي فئة الاب على عملية بنائية توقيعها فارغ، وبالتالي يمكن استدعاء العملية البنائية الفارغة بطريقتين:
        //الاولى: الا نكتب اي شيء
        //الثانية: كتابة الكلمة base مع اقواس فارغة :base()

    }
}
