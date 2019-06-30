using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara.Classes
{
    class Kumbaraa
    {
        //public Kumbara(string isim , double hacim)
        //{
        //    this.Isim = isim;
        //    this.Hacim = hacim;
        //}
        public double Hacim { get; set; }
        public string Isim {get; set; }
        public double Miktar { get; set; }

         public void KumbarayiKir()
        {
            this.Miktar = 0;
            this.Hacim= 0;
        }
    }
}
