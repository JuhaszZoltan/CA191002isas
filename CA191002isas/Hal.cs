using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191002isas
{
    class Hal : Allat
    {
        public ConsoleColor Szin { get; set; }
        public void Uszik()
        {
            Console.ForegroundColor = this.Szin;
            Console.WriteLine($"{this.Nev} arrébbúszik...");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
