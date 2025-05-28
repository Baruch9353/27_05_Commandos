using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string codeName) : base(name, codeName) { }
        public void Parachute()
        {
            Console.WriteLine("The soldier is ready to parachute.");
        }
        public override void  Attack()
        {
            Console.WriteLine($"Air commando soldier code name: {CodeName} is active");
        }
    }   
}
