namespace BasicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Kalle");
            //Employee e = new Employee("Anna", 25000);
            //Admin a = new Admin("Stefan", 50000, "HR");

            //Console.WriteLine(p.Name);
            //Console.WriteLine(e.Name + " " + e.Salary);
            //Console.WriteLine($"{a.Name} {a.Salary} {a.Department}");
            //p.Do();
            //e.Do();
            //a.Do(); 

            //Console.WriteLine(p.ToString());
            //Console.WriteLine(e.ToString());
            //Console.WriteLine(a.ToString());
            Person person = new Employee();
            Person person2 = new Person();
            Employee admin = new Admin();
            Person admin2 = new Admin();
            Admin admin3 = new Admin();
            Dog dog = new Dog(); 

            //admin.Do();            
            //admin3.Do();
            

            var people = new List<IPerson>
            {
                admin,
                admin2,
                admin3,
                person,
                person2,
                dog
            };

            foreach(var p in people)
            {
                p.Do(); 
            }
        }


    }

}
