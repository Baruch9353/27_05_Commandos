using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class CommandoFactory
    {
        //List of commando
        private List<Commando> commandos = new List<Commando>();

        //Create New commando and puts the commando to a list
        public Commando CreateNewCommando(string type ,string name, string codeName)
        {
            type = type.ToLower();
            switch(type)
            {
                case "air":
                    AirCommando airCommando = new AirCommando(name, codeName);
                    commandos.Add(airCommando);
                    return airCommando;
                case "sea":
                    SeaCommando seaCommando = new SeaCommando(name, codeName);
                    commandos.Add(seaCommando);
                    return seaCommando;
                default:
                    Commando Commando = new Commando(name, codeName);
                    commandos.Add(Commando);
                    return Commando;
            }
        }

        //Get Commando
        public Commando GetCommando(int num)
        {
            return commandos[num];
        }

        //Prints the commando list
        public void PrintsCommandoList()
        {
            foreach (Commando commando in commandos)
            {
                Console.Write(commando);
            }
            Console.WriteLine("");
        } 
    }
}
