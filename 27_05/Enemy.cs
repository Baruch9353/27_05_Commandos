using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _27_05
{
    internal class Enemy
    {
        public string NameOfEnemy;
        public int LifePercentage;
        public string Status;


        public Enemy(string nameOfEnemy)
        {
            NameOfEnemy = nameOfEnemy;
            LifePercentage = 100;
            Status = "alive";
        }

        //Updates and returns life percentage
        
        public int TakesLife(int numDownload)
        {
            LifePercentage = LifePercentage - numDownload;
            UpdatesStatus();
            return LifePercentage;
        }

        //If the life percentage == 0, the status updates to dead.
        private void UpdatesStatus()
        {
            if (LifePercentage <= 0) { Status = "dead"; }
        }

        //Prints I'm an enemy!!!
        public void Scream()
        {
            Console.WriteLine("I'm an enemy!!!");
        }
        public override string ToString()
        {
            return $"Name Of Enemy: {NameOfEnemy}  \n" +
                   $"Life Percentage: {LifePercentage}  \n" +
                   $"Status: {Status} \n";
        }
    }
}
