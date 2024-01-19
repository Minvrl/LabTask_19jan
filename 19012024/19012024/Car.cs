using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19012024
{
    internal class Car:Vehicle,IRefuel
    {
        public int FuelCapacity;
        public decimal CurrentFuel;
        private decimal _fuelFor1KM;
        protected const decimal FuelPricePerL = 5;
        public decimal FuelFor1KM {
            get
            {
                return _fuelFor1KM;
            } 
            set
            {
                _fuelFor1KM= value;
            }
        }
        


        public Car()
        {

        }
        
        public override void Drive(decimal km)
        {
            if(CurrentFuel == 0)
            {
                Console.WriteLine("Benzin yoxdur !");
            }
            else
            {
                FuelFor1KM *= km;
                CurrentFuel-= FuelFor1KM;
                Milleage += km;
            }
        }

        public void Refuel(decimal wallet)
        {
            if(wallet > FuelPricePerL )
            {
                Console.WriteLine($"1 litr ucun benzin qiymeti : {FuelPricePerL} manat");
                decimal needed = FuelCapacity - CurrentFuel;
                decimal price = FuelPricePerL * needed;
                wallet -= price;

                CurrentFuel = FuelCapacity;
                Console.WriteLine("Car refueled !");
                Console.WriteLine($"Paid : {price} , Current wallet : {wallet}");
            }
            else
            {
                Console.WriteLine("Yeterli qeder pulunuz yoxdur !");
            }
            
          
        }

        
    }
}
