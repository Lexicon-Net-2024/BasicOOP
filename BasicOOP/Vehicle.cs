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
    internal class Vehicle : IDrivable, IStopable
    {
        public string Brand { get; set; }
        //public int Gas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Vehicle(string brand)
        {
            Brand = brand;
        }
        public string Drive(int distance)
        {
            return $"{GetType().Name} drove for {distance}!";
        }

        public void Stop()
        {
            Console.WriteLine($"{GetType().Name} stopped!");
        }
    }

    internal class Car : Vehicle, IStopable, IDrivable
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }        
    }
}
