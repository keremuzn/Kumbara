using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara.Classes
{
    class Para : Kumbaraa
    {
        Random rnd = new Random();
        //public Para(string isim, double hacim)
        //{
        //    this.Isim = isim;
        //    this.Hacim = hacim;
        //}
        public const double Pi = 3.1;
        public double En { get; set; }
        public double Boy { get; set; }
        public double Yukseklik { get; set; }



        public double Cap { get; set; }




        public void ParaAt(Kumbaraa x)
        {
            x.Hacim = x.Hacim + this.Hacim;
            x.Miktar = x.Miktar + this.Miktar;
        }

        public void Bosluk()
        {
            this.Hacim = this.Hacim + (this.Hacim * (rnd.Next(25, 75) * 0.01));
        }
        public void Katla()
        {
            this.En = this.En * 0.25;
            this.Yukseklik = this.Yukseklik * 4;
        }
    }
}
