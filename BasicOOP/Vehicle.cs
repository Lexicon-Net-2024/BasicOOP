using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public interface IDrivable
    {

        // public int Gas { get; set; }
        string Drive(int distance);
    }
    //public interface IDrivable2
    //{
    //    // public int Gas { get; set; }
    //    string Drive(int distance)
    //    {
    //        return $"Drive2 drove for {distance}!";
    //    }
    //}
    internal interface IStopable
    {
        void Stop();
    }

    internal abstract class AbstractVehicle : IDrivable
    {
        //Available in derived classes but not from outside.
        protected bool ProtectedBool; 
        public virtual string Drive(int distance)
        {
            return $"{GetType().Name} drove for {distance}!";
        }

        public abstract string Turn();

    }

    internal class Vehicle : AbstractVehicle, IStopable
    {
        public string Brand { get; set; }


        public Vehicle(string brand)
        {
            
            Brand = brand;
        }
        //public override string Drive(int distance)
        //{
        //    return $"{GetType().Name} drove for {distance}!";
        //}

        public void Stop()
        {
            Console.WriteLine($"{GetType().Name} stopped!");
        }

        public override string Turn()
        {
            return "Turning"; 
        }
    }

    //Sealed cannot be derived from
    internal /*sealed*/ class Car : Vehicle, IStopable, IDrivable
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }
    }

    internal class Volvo : Car
    {
        public Volvo(string brand, string model) : base(brand, model)
        {
        }

        public string VolvoSpecialMethod()
        {
            return "From Volvo";
        }
    }
    internal class Bicycle : IDrivable
    {
        public string Drive(int distance)
        {
            return $"{GetType().Name} drove for {distance}!";
        }
    }
}
