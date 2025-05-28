using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class Game
    {
        // Instances of your factories
        CommandoFactory commando = new CommandoFactory();
        EnemyFactory enemy = new EnemyFactory();
        WeaponFactory weapon = new WeaponFactory();

        public void Start()
        {
            // Create commandos of different types
            Commando c1 = commando.CreateNewCommando("air", "c1", "01");
            Commando c2 = commando.CreateNewCommando("sea", "c2", "02");
            Commando c3 = commando.CreateNewCommando("infantry", "c3", "03");

            Commando a1 = commando.CreateNewCommando("air", "a1", "11");
            Commando a2 = commando.CreateNewCommando("sea", "a2", "22");
            Commando a3 = commando.CreateNewCommando("infantry", "a3", "33");

            // Create enemies
            Enemy Mohamad = enemy.CreateNewEnemy("Mohamad");
            Enemy Ahmed = enemy.CreateNewEnemy("Ahmed");
            Enemy sinwar = enemy.CreateNewEnemy("sinwar");

            // Print lists of commandos and enemies end weapon
            commando.PrintsCommandoList();
            enemy.PrintsEnemyList();
            weapon.PrintsWeaponList();

            // Create weapons using WeaponFactory
            Weapon m16 = weapon.CreateNewWeapon("M16", "COLT", 29);
            Weapon ak47 = weapon.CreateNewWeapon("AK47", "KALASHNIKOV", 30);


            // Shoot the weapons once (reduce bullets by 1)
            Console.WriteLine("\nShooting weapons:");
            m16.NumberOfBalls = m16.Shoot();
            ak47.NumberOfBalls = ak47.Shoot();

            // Shoot the weapons again to show bullets reduce more
            m16.NumberOfBalls = m16.Shoot();
            ak47.NumberOfBalls = ak47.Shoot();

            // Show some commando actions
            c1.Walk();
            c2.Hide();
            a3.Attack();

            // Enemies shout
            Mohamad.Scream();
            Ahmed.Scream();

            // Enemy takes damage (life reduces)
            sinwar.TakesLife(30);
            sinwar.TakesLife(70);
            Console.WriteLine(sinwar);
        }
    }

}
