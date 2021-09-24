using System.Collections.Generic;

namespace KG02
{


    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            Employee e = new SWE("Jens");
            Manager m = new Manager("Thomas", e);
            Manager m2 = new Manager("Søren", m);


            int i = 1 + 1;
            int k = i;
            int l = k + 1;
            employees.Add(e);
            employees.Add(m);
            employees.Add(new RS("PEr"));
            employees.Add(m2);

            foreach (Employee item in employees)
            {
                item.Work();
            }



            m2.ManagedEmployee = m2;


        }
    }
}
