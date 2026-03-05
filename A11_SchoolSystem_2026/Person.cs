using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_SchoolSystem_2026
{
     class Person 
    {
        private int Id;
        protected string Name;

        public Person(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            Console.WriteLine("Person1"); 
        }

        public Person(int Id)
        {
            this.Id = Id;
            this.Name = "Test";
            Console.WriteLine("Person2");
        }

        public Person():this(888)
        {
            this.Id += 1;
            Name += "AAA";
            Console.WriteLine("Person3");
        }


        //:base()
        //او بدون كتابة اي شيئ


    }
}
