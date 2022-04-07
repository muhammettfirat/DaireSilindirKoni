using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Boyahane
    {
        public void Boya(IBoyanabilir arac,ConsoleColor yeniRenk)
        {
            ((Arac)arac).Renk = yeniRenk;
            arac.ToString();
        }
    }
}
