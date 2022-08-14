using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Class_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayi;
            sayi = random.Next(1,82);
            Console.WriteLine(sayi);

            Console.Read();
        }
    }
}
