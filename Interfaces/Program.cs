using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        //Interface new  LENEMEZ.!!!!!!!!!!
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager =new EmployeeManager();
            //employeeManager.Add();

            //CustomerManager customerManager = new CustomerManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());


            Console.ReadLine();

        }
    }
    //class PersonManager
    //{
    //Implomented operation :Tamamnlanmış operasyon
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }
    //}
    interface IPersonManager
    {
        //UnImplomented operation :Tamamnlanmamış operasyon
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    
    // Inherits ---> Class ------------------ Implements --->Interface

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
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

        //public void AddCustomer(CustomerManager customerManager)
        //{
        //    customerManager.Add();
        //}
        //public void AddEmployee(EmployeeManager employeeManager)
        //{
        //    employeeManager.Add();
        //}
    }

}
