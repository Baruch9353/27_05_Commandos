using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirCommando dan = new AirCommando("Daniel", "91");
            //dan.Attack();

            Commando bar = new Commando("Baruch", "01");
            //bar.CodeName = "03";

            SeaCommando dov = new SeaCommando("David", "99");

            //Console.WriteLine(bar.SayName("colonel"));
            //Weapon gan = new Weapon("gan", "rusha", 8);
            //gan.Shoot();

            Commando[] commandos = { bar, dan, dov};
            foreach (Commando c in commandos)
            {
                c.Attack();
            }
        }
    }
}
