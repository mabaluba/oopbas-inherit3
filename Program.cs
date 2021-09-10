using System;

namespace oopbas_inherit3
{
    public class Vehicle
    {
        public int Price;
        public int Speed;
        public int Year;
        
    }
    public class Plane : Vehicle
    {
        public int Altitude;
        public int PassAmount;

        public void Display(string name)
        {
            Console.WriteLine($"{name}:\nКоличество пассажиров {PassAmount},\nСтоимость {Price},\nСкорость {Speed},\nГод выпуска {Year},\nВысота полета {Altitude}");
        }
    }
    public class Car : Vehicle
    {
       
    }
    public class Ship : Vehicle
    {
        public int PassAmount; 
        public string Port;

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            var plane1 = new Plane();
            plane1.PassAmount = 500;
            plane1.Price = 1000000;
            plane1.Speed = 500;
            plane1.Year = 2000;
            plane1.Display(nameof(plane1));
            
            Ship ship1 = new();
            ship1.PassAmount = 1000;
            ship1.Port = "LasAngeles";
            ship1.Price = 1500000;
            ship1.Speed = 150;
            ship1.Year = 1995;
            
            Car car1 = new Car();
            
        }
    }
}
