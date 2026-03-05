using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
    class Teacher : Person
    {

        private double Salary;
        private bool IsSport;

        public Teacher(int Id, string Name, double Salary, bool IsSport) // او بدون كتابة اي شيء او الاستدعاء بشكل صريح:base()
        {
            this.Salary = Salary;
            this.IsSport = IsSport;
            Console.WriteLine("Teacher");
        }
    }
}
