using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class Commando
    {
        internal string Name;
        public string CodeName {get; set;}
        public string[] Tools = new string[] { "Hammer", "chisel", "rope", "bag", "water", "bottle" };
        public string Status = "alive";

        public Commando(string name, string codeName)
        {        
            Name = name;
            CodeName = codeName;
        }

        //Returns the commando name according to the applicant's rank.
        public string SayName(string commanderRank)
        {
            commanderRank = commanderRank.ToUpper();
            if (commanderRank.Equals("GETTER"))
            {
                return Name;
            }
            else if (commanderRank.Equals("COLONEL"))
            {
                return CodeName;
            }
            else
            {
                return "You are not authorized to access this information";
            }
        }

        //Prints to the console that the soldier is leaving(changes the status)
        public void Walk()
        {
            Status = "soldier goes";
            Console.WriteLine($"The soldier {Name} goes");
        }

        //Prints to the console that the soldier is hiding(changes the status)
        public void Hide()
        {
            Status = "soldier is hiding";
            Console.WriteLine($"The soldier {Name} hiding.");
        }

        //Prints to the console that a command with code name X is active.
        public virtual void Attack()
        {
            //Status = $"Commando codename {CodeName} is active";
            Console.WriteLine($"Commando name: {Name} is active");
        }

        public override string ToString()
        {
            return $"Name of soldier: {Name}  \n" +
                   $"Code Name: {CodeName} \n" +
                   $"Status: {Status}  \n";
        }
    }
    
}
