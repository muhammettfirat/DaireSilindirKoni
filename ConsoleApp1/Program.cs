using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ///Soru:Aracları  boyayan boyahane uygulamasını yazınız?araçlarım
            ///Ferrari, Serce, Bmx
            Ferrari ferrari = new Ferrari();
            Serce serce = new Serce();
            Bmx bmx = new Bmx();

            Console.WriteLine(ferrari);
            Console.WriteLine(serce);
            Console.WriteLine(bmx);
            Boyahane boyahane = new Boyahane();
            boyahane.Boya(ferrari, ConsoleColor.Red);
            boyahane.Boya(serce, ConsoleColor.Cyan);
            Console.WriteLine(ferrari);
            Console.WriteLine(serce);
            Console.WriteLine(bmx);
        }
    }
}
