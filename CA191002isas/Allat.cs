using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191002isas
{
    class Allat
    {
        public string Nev { get; set; }
        public DateTime SzuliNap { get; set; }

        public Allat Szaporodik()
        {
            return new Allat();
        }
    }
}
