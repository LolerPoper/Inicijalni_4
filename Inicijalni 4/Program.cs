using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Unesite vrijednosti za x, y i z stranice pravokutnog trokuta s tim da je z hipotenuza: ");
            do
            {
                x = Convert.ToInt16(Console.ReadLine());
            }
            while (x <= 0);
            do
            {
                y = Convert.ToInt16(Console.ReadLine());
            }
            while (y <= 0);
            do
            {
                z = Convert.ToInt16(Console.ReadLine());
            }
            while (z <= 0);

            if(z == Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)))
            {
                Console.WriteLine("Ovo su strane pravokutnog trokuta.");
            }
            else
            {
                Console.WriteLine("Ovo nisu strane pravokutnog trokuta.");
            }

            Console.ReadKey();
        }
    }
}
