using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class WeaponFactory
    {
        public List<Weapon> weapons = new List<Weapon>();
        public List<IShootable> shootables = new List<IShootable>();
        public List<IBreakable> breakables = new List<IBreakable>();

        //Create New Weapon
        public Weapon CreateNewWeapon(string name, string manufacturer, int numberOfBalls)
        {
            Weapon weapon = new Weapon(name, manufacturer, numberOfBalls);
            AddsWeaponToList(weapon);
            return weapon;
        }

        //Add weapon to list
        public void AddsWeaponToList(Weapon weapon)
        {
            weapons.Add(weapon);
        }

        //Create new M16
        public M16 CreateM16()
        {
            M16 m16 = new M16();
            shootables.Add(m16);
            return m16;
        }

        //Create new AK47
        public AK47 CreateAK47()
        {
            AK47 ak47 = new AK47();
            shootables.Add(ak47);
            return ak47;
        }

        //Create new Stone
        public Stone CreateStone(string name, double weight, string color)
        {
            Stone stone = new Stone(name, weight, color);
            breakables.Add(stone);
            return stone;
        }

        //Create new Knife
        public Knife CreateKnife(string name, string metalType, string manufacturer, string color, double weight, int maxHits)
        {
            Knife knife = new Knife(name, metalType, manufacturer, color, weight, maxHits);
            breakables.Add(knife);
            return knife;
        }

        //Print weapons list
        public void PrintsWeaponList()
        {
            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine("Weapons List");
                Console.Write(weapon);
            }
        }
    }
}
