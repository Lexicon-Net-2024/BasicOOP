namespace BasicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Kalle");
            Employee e = new Employee("Anna", 25000);
            Admin a = new Admin("Stefan", 50000, "HR");

            Console.WriteLine(p.Name);
            Console.WriteLine(e.Name + " " + e.Salary);
            Console.WriteLine($"{a.Name} {a.Salary} {a.Department}");
            p.Do();
            e.Do();
            a.Do(); 


        
        }


    }

}
