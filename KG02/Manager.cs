namespace KG02
{
    class Manager : Employee
    {
        public Manager(string name, Employee e) : base(name)
        {
            ManagedEmployee = e;
            Id = 10;
        }

        public override void Work()
        {
            Manage(ManagedEmployee);
        }
        private void Manage(Employee e)
        {
            System.Console.WriteLine("Managing "+e.Name);
        }


        public bool IsManagingAnyone => ManagedEmployee == null;


        public Employee ManagedEmployee { get; set; }
    }
}
