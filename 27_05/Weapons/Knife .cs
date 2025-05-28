using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    class Knife : IBreakable
    {
        public string Name { get; set; }
        public string MetalType { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Status { get; set; } = "Intact";
        public int MaxHits { get; set; }
        public int CurrentHits { get; set; } = 0;

        public Knife(string name, string metalType, string manufacturer, string color, double weight, int maxHits)
        {
            Name = name;
            MetalType = metalType;
            Manufacturer = manufacturer;
            Color = color;
            Weight = weight;
            MaxHits = maxHits;
        }
    }
}
