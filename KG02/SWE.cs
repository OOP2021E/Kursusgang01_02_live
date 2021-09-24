using System;

namespace KG02
{
    class SWE : Employee
    {
        public SWE(string name) : base(name)
        {
        }

        public override void Work()
        {
            Code();
        }

        private void Code()
        {
            Console.WriteLine("Coding");
        }
    }
}
