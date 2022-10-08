using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutoVerseny
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> autoverseny = new List<Versenyzo>();
            #region 2. feladat
            using (var sr = new StreamReader("autoverseny.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    autoverseny.Add(new Versenyzo(sor));
                }
            }
            #endregion

            #region 3. feladat
            Console.WriteLine("3. feladat: " + autoverseny.Count);
            #endregion

            #region 4. feladat
            var FF_GPX_3 = autoverseny.SingleOrDefault(x => x.VersenyzoNeve.Equals("Fürge Ferenc") && x.Palya.Equals("Gran Prix Circuit") && x.Kor.Equals(3)).Korido;
            Console.WriteLine("4. feladat: " + FF_GPX_3.TotalSeconds + " másodperc");
            #endregion

            #region 5. feladat
            Console.WriteLine("5. feladat: \n Kérem egy versenyző nevét:");
            #endregion

            Console.WriteLine();
        }
    }
}
