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
        public string Phone;

        //public static void F1() { }
        public Person(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            //Console.WriteLine("Person1"); 
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

        public int GetId()
        {
            return this.Id;
        }

        private void G1()
        {
            Console.WriteLine("This is G1");
        }

        protected void G2()
        {
                       Console.WriteLine("This is G2");
        }

        public virtual void G3()
        {
            Console.WriteLine("This is G3");
        }


        public override string ToString()
        {
            return "Im Person";
        }

        public string F10()
        {
            return "Im Person";
        }

        //:base()
        //او بدون كتابة اي شيئ


    }
}
