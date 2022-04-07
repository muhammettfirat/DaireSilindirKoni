using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Daire
    {
        public double r { get; set; }
        public virtual double Hesapla()
        {
            return Math.PI * r * r;
        }
    }
    class Silindir:Daire
    {
        public double h { get; set; }
        public override double Hesapla()
        {
            return base.Hesapla()*h;
        }
    }
    class Koni:Silindir
    {
        public override double Hesapla()
        {
            return (base.Hesapla() * h)/3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Daire d = new Daire() { r = 3 };
            Silindir s = new Silindir() { r = 3, h = 10 };
            Koni k = new Koni() { r = 3, h = 10 };
            Console.WriteLine(d.Hesapla());
            Console.WriteLine(s.Hesapla());
            Console.WriteLine(k.Hesapla());
            Console.WriteLine("-----------------------------");
            ArrayList list = new ArrayList();
            list.Add(d);
            list.Add(s);
            list.Add(k);
            foreach (Daire item in list)
            {
                Console.WriteLine(item.Hesapla());
            }
        }
    }
}
