using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat2();
            Console.ReadKey();
        }

        static void Feladat2()
        {
            List<int> szamok = new List<int>();
            Console.WriteLine("kerem adjon meg egy szamot: ");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                if (szam != 0)
                {
                    szamok.Add(szam);
                    while (szam > 0)
                    {
                        Console.WriteLine("kerek megegy szamot: ");
                        szam = Convert.ToInt32(Console.ReadLine());
                        szamok.Add(szam);
                    }
                    Console.WriteLine("kilepett");
                }
                else 
                {
                    Console.WriteLine("kilepett");
                }
            }
            catch (Exception)
            {
                throw new Exception("az adott erteknek szamnak kell lennie");
            }
        }
    }
}
