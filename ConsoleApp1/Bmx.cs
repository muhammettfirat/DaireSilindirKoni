using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bmx:Arac
    {
        public override string ToString()
        {
            Console.ForegroundColor = Renk;
            return "BMX";
        }
    }
}
