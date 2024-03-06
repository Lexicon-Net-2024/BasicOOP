namespace BasicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Extension-method
            string name = "Kalle";
            var res = name.AddString("Anka");

            Console.WriteLine(res);

            try
            {
                //int.Parse("Test");
                Employee e = new Employee();
                e.AddEmployee(null, 25000);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Det där var inte så bra!");

            }
            catch(OverflowException ex)
            {

            }
            catch(Exception ex)
            {

            }
            finally
            {

            }


           


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
            //Person person = new Employee();
            //Person person2 = new Person();
            //Employee admin = new Admin();
            //Person admin2 = new Admin();
            //Admin admin3 = new Admin();
            //Dog dog = new Dog(); 

            ////admin.Do();            
            ////admin3.Do();


            //var people = new List<IPerson>
            //{
            //    admin,
            //    admin2,
            //    admin3,
            //    person,
            //    person2,
            //    dog
            //};

            //foreach(var p in people)
            //{
            //    p.Do(); 
            //}

            Vehicle v = new Vehicle("Volvo");
            //Console.WriteLine(v.Drive(10));
            //v.Stop();
            
            Car c = new Car("SAAB", "900");
            //Console.WriteLine(c.Drive(15));
            //c.Stop();
            //
            Volvo volvo = new Volvo("Volvo", "V70");
            //Console.WriteLine(volvo.Drive(13));

            Bicycle bike = new Bicycle();

            var vehicles = new List<IDrivable>
            {
                v,
                c,
                volvo,
                bike
            };

            foreach (IDrivable vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(50));

                //Different ways to case value:


                //Unsafe casting
                //Volvo volvo2 = (Volvo)vehicle;

                //Volvo volvo3 = vehicle as Volvo;
                //Console.WriteLine(volvo3.VolvoSpecialMethod());

                //Volvo volvo4 = vehicle as Volvo;
                //if(volvo4 != null)
                //{
                //    Console.WriteLine(volvo4.VolvoSpecialMethod());
                //}

                //if (vehicle is Volvo)
                //{
                //    Volvo volvo5 = (Volvo)vehicle;
                //    Console.WriteLine(volvo5.VolvoSpecialMethod());
                //}

                if(vehicle is Volvo castedToVolvo)
                {
                    Console.WriteLine(castedToVolvo.VolvoSpecialMethod());
                }


            }



        }


    }

}
