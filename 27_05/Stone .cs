using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    class Stone : IBreakable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Status { get; set; } = "Intact";
        public int MaxHits { get; set; } = 5;
        public int CurrentHits { get; set; } = 0;

        public Stone(string name, double weight, string color)
        {
            Name = name;
            Weight = weight;
            Color = color;
        }
    }
}
