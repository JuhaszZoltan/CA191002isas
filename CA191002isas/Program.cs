using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191002isas
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Cica()
            {
                Nev = "Lukrécica",
                SzuliNap = new DateTime(2009, 07, 11),
                Iq = 70
            };

            var h1 = new Hal()
            {
                Nev = "Nincs",
                SzuliNap = new DateTime(2017, 03, 15),
                Szin = ConsoleColor.DarkRed
            };

            Cica[] ct = new Cica[] { c1 };

            object o1 = 22;
            string o2 = "vasútállomás";
            object o3 = c1;
            object o4 = new Allat();

            double d = 22;

            //+ * / % == &&
            //is as

            if (o1 is Cica) Console.WriteLine((o1 as Cica).Nev);
            else Console.WriteLine("ez nem egy kibaszott macska!");

            var lst = new List<Allat>()
            {
                h1,
                c1
            };

            foreach (var a in lst)
            {
                if (a is Hal) (a as Hal).Uszik();
                else (a as Cica).Nyavog();
            }

            Console.ReadKey();
        }
    }
}
