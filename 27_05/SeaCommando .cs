using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }
        public void Dive()
        {
            Console.WriteLine("The soldier is ready to dive.");
        }
        public override void Attack()
        {
            Console.WriteLine($"Sea commando soldier codename {CodeName} is active");
        }
    }
}
