using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kovács_Márk_20201112_Órai
{
    struct titanic
    {
        public string Kategoria;
        public int Tulelo;
        public int Eltunt;
    }

    class Program
    {
        static List<titanic> Titanic = new List<titanic>();
        static string seged;
        static void Main(string[] args)
        {
            
            F01();
            F02();
            F03();
            F04();
            F05();
            F06();
            F07();
            Console.ReadLine();
        }

        private static void F07()
        {
            Console.WriteLine("7. Feladat: ");
            int tobb = int.MinValue;
            string tobbnev="na";
            foreach (var vizsgalt in Titanic)
            {
                if (vizsgalt.Tulelo>tobb)
                {
                    tobb = vizsgalt.Tulelo;
                    tobbnev = vizsgalt.Kategoria;
                }
            }
            Console.WriteLine(tobbnev);
        }

        private static void F06()
        {
            List<string> Arany = new List<string>();
            foreach (var vizsgalt in Titanic)
            {
                if ((vizsgalt.Tulelo + vizsgalt.Eltunt) * 0.6 <= vizsgalt.Eltunt)
                {
                    Arany.Add(vizsgalt.Kategoria);
                }
            }
            Console.WriteLine("6. Feladat:");
            for (int i = 0; i < Arany.Count; i++)
            {
                Console.WriteLine(Arany[i]);

            }

        }

        private static void F05()
        {
            Console.WriteLine("5. Feladat: ");
            foreach (var vizsgalt in Titanic)
            {
                if (seged==vizsgalt.Kategoria)
                {
                    Console.WriteLine(vizsgalt.Kategoria+" "+vizsgalt.Tulelo+" fő");
                }
            }
        }

        private static void F04()
        {
            bool vannincs = false;
            Console.WriteLine("4. Feladat: ");
            Console.WriteLine("Kérem adjon meg egy keresendő szót: ");
            string keresett = Console.ReadLine();
            foreach (var vizsgalt in Titanic)
            {
                if (keresett==vizsgalt.Kategoria)
                {
                    vannincs = true;
                    seged = vizsgalt.Kategoria;
                }
            }

            if (vannincs==true)
            {
                Console.WriteLine("Van találat!");
            }
            else
            {
                Console.WriteLine("Nincs találat!");
            }
        }

        private static void F03()
        {
            int ossz = 0;
            foreach (var vizsgalt in Titanic)
            {
                ossz = ossz + vizsgalt.Tulelo + vizsgalt.Eltunt;
            }
            Console.WriteLine($"3. Feladat: "+ossz+" fő");
        }

        private static void F02()
        {
            Console.WriteLine("2. Feladat: "+Titanic.Count+" db");
        }

        private static void F01()
        {
            var sr = new StreamReader("titanic.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');

                Titanic.Add(new titanic()
                {
                    Kategoria = sor[0],
                    Tulelo = int.Parse(sor[1]),
                    Eltunt = int.Parse(sor[2]),
                });
            }
            sr.Close();
        }
    }
}
