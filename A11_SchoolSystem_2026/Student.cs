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
            Console.WriteLine("this.Phone:"+ this.Phone);
            Console.WriteLine("base.Phone:" + base.Phone);
            Console.WriteLine("Phone:" + Phone);
            //this.Id
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
