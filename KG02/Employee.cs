using System;

namespace KG02
{


    class RS : Employee
    {
        public RS(string name) : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine("flying");
        }
    }

    abstract class Employee 
    {

        public abstract void Work();

        public string Name { get; set; }
        public Employee(string name) :base()
        {
            Name = name;
            Console.WriteLine($"Jeg hedder {name}");
        }

        public int Id { get; protected set; }
    }
}
