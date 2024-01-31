using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class Feladatok
    {
        private List<int> szamok = new List<int>();
        public List<int> Szamok { get => szamok; set => szamok = value; }

        public void Feladat2()
        {
            Console.WriteLine("kerem adjon meg egy szamot: ");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                if (szam != 0)
                {
                    while (szam > 0)
                    {
                        szamok.Add(szam);
                        Feladat3();
                        Console.WriteLine("kerek megegy szamot: ");
                        szam = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("kilepett");
                    Feladat4();
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

        public void Feladat3()
        {
            foreach (var item in szamok)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        public void Feladat4()
        {
            int max = szamok[0];
            foreach (var item in szamok)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine($"A legkisebb ertek: {max}");
        }
    }
}
