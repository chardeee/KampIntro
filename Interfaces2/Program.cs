using System;

namespace Interfaces2
{
    class Program
    {
        //interface new'lenmez
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Update(new InternManager());
        }

    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();

    }

    //inherits - class .......... implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellemi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
