using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class EnemyFactory
    {
        //List of enemies
        public List<Enemy> enemies = new List<Enemy> ();

        //Create New Enemy
        public Enemy CreateNewEnemy(string name)
        {
            Enemy enemy = new Enemy(name);
            AddsEnemyToList(enemy);
            return enemy;
        }

        //Adds an enemy to the list
        public void AddsEnemyToList(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        //Prints the enemy list
        public void PrintsEnemyList()
        {
            foreach(Enemy enemy in enemies)
            {
                Console.Write(enemy);
            }
            Console.WriteLine("");
        }
    }
}
