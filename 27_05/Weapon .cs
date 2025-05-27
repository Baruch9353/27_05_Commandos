using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int NumberOfBalls;
        public Weapon(string name, string manufacturer, int numberOfBalls) 
        { 
            Name = name;
            Manufacturer = manufacturer;
            NumberOfBalls = numberOfBalls;
        }

        //Prints a shot and reduces one bullet
        public int Shoot()
        {
            if (NumberOfBalls > 0)
            {
                Console.WriteLine($"A bullet shot! {NumberOfBalls - 1} balls left");
                return NumberOfBalls - 1;
            }
            else
            {
                Console.WriteLine("No balls left");
                return 0;
            }
        }
    }
}
