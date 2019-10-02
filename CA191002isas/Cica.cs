using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191002isas
{
    class Cica : Allat
    {
        public int Iq { get; set; }

        public static Cica Parse (object o)
        {
            return (Cica)o;
        }

        public override string ToString()
        {
            return this.Nev;
        }

        public void Nyavog()
        {
            Console.WriteLine($"{this.Nev} mondja: meow-meow!");
        }
    }
}
