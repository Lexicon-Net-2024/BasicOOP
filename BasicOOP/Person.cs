using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    internal class Person
    {
        public string Name { get; set; }

        public virtual void Do()
        {
            Console.WriteLine("Person do");
        }

        //Finns alltid med
        //public Person()
        //{

        //}
        public Person(string name)
        {
            Name = name;
        }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }
        public Employee(string name, int salary) : base(name)
        {
            Salary = salary;
        }

    }

    internal class Admin : Employee
    {
        public string Department { get; set; }
        public Admin(string name, int salary, string department) : base(name, salary)
        {
            Department = department; 
        }

        public override void Do()
        {
            //base.Do();
            Console.WriteLine("Admin do");
        }
    }
}
