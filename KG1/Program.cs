using System;
using System.Collections.Generic;

namespace KG1
{


    class Student
    {
        private string cpr;

        public int Age { get; set; }

        List<Student> Palls { get; }

        private Student() {
            Palls = new List<Student>();
        }
        void stringF(string s)
        {

        }
        void intF(int k)
        {

        }
        void inggenF()
        {
            intF(10);
        }

        public Student(string name)
        {
            Name = name;
        }

        public Student(string Name, int age) : this(Name)
        {
            Age = age;
        }

        public string CPR { get; set; }

        private string _name;

        public int MyProperty { get; }

        public int GetAge()
        {
            return GetAge();
        }


        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                _name = value;
                //if (char.IsUpper(value[0]))
                //{
                //    _name = value;
                //}
                //else
                //{
                //    Console.WriteLine("navnet er forkert");
                //    //throw new Exception();
                //}
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();

            Console.WriteLine(args.Length);

            foreach (string item in args)
            {

            }

            Student s = new Student("Thomas", 10);
            //s.Name = "thomas";

            Console.WriteLine(s.Name);


            s.Name = "Thomas";
            s.CPR = "1234";

            Student t = new Student("Jens");


            
        }
    }
}
