using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    class M16 : IShootable
    {
        public string CanShoot { get; set; } = "Yes";
        public string HasAmmo { get; set; } = "Has ammo";
    }

}
