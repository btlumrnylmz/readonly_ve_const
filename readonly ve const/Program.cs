using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_ve_const
{
    public class Araba
    {
        public readonly string Marka;
        public const int tekerlekSayisi = 4;
        public Araba(string marka)
        {
            Marka = marka;
        }
        public void Tanit()
        {
            Console.WriteLine($"Bu araba {Marka} marka ve {tekerlekSayisi} tekerlekli.");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba("Toyota");
            araba.Tanit();

        }
    }
}
