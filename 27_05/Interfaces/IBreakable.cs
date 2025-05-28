using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal interface IBreakable
    {
        string Status { get; set; }
        int MaxHits { get; set; }
        int CurrentHits { get; set; }
    }

}
