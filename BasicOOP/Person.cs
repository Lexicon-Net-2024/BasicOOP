using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{

    internal interface IPerson
    {
        string Name { get; set; }
        void Do(); 
    }

    internal class Dog : IPerson
    {
        public string Name { get; set; }

        public void Do()
        {
            Console.WriteLine("Dog do");
        }       
    }
    internal class Person : IPerson
    {
        public string Name { get; set; }


        //public string Name { get; set; }

        public virtual void Do()
        {
            Console.WriteLine("Person do");
        }

        //Finns alltid med
        //public Person()
        //{

        //}
        //public Person(string name)
        //{
        //    Name = name;
        //}

        public override string ToString()
        {
            return $"This is from {GetType().Name}";
        }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }
        //public Employee(string name, int salary) : base(name)
        //{
        //    Salary = salary;
        //}
        public override string ToString()
        {
            return $"This is salary {Salary}";
        }

        public override void Do()
        {
            Console.WriteLine("Employee do");
        }

        public void AddEmployee(string name, int salary)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }

    }

    internal class Admin : Employee
    {
        public string Department { get; set; }
        //public Admin(string name, int salary, string department) : base(name, salary)
        //{
        //    Department = department; 
        //}

        public override void Do()
        {
            //base.Do();
            Console.WriteLine("Admin do");
        }
    }
}
