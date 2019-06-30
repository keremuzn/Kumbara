using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kumbara.Classes
{
       public class Hata
    {

           static public void ParaEklemekIcin()
            {
            MessageBox.Show(" Para Eklemek için seçmeniz gerekli");
            }

            static public void KumbarayaKoymadanOnce()
        {
            MessageBox.Show("Kağıt paraları kumbaraya koymadan önce katlamanız gerekmektedir.");
        }
        static public void Kirma2()
        {
            MessageBox.Show("Kumbaranız  yapıştırılamadı tekrar kıramazsınız.");
        }
        static public void HacimTasma()
        {
            MessageBox.Show("Kumbaranızda yer kalmamıştır");
        }
        static public void KirilmisEkleme()
        {
            MessageBox.Show("2 Kere kırılmış bir kumbaraya para ekleyemezsiniz.");
        }
        static public void KatlamakSecmek()
        {
            MessageBox.Show("Kagıt paranızı katlamak için seçmeniz gerekmektedir.");
        }
        static public void DemirParaKatlanmaz()
        {
            MessageBox.Show("Demir parayı katlayamazsınız.");
        }
    }
}
