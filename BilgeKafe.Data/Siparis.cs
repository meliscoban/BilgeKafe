using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKafe.Data
{
    [Table("Siparisler")]
    public class Siparis
    {
        public int Id { get; set; }

        public int MasaNo { get; set; }

        public DateTime? AcilisZamani { get; set; } = DateTime.Now;
        
        public DateTime? KapanisZamani { get; set; }

        public SiparisDurum Durum { get; set; } = SiparisDurum.Aktif;
        
        public decimal OdenenTutar { get; set; }
        
        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; } = new HashSet<SiparisDetay>();

        [NotMapped]
        public string ToplamTutarTL => $"{ToplamTutar():n2}₺";

        public decimal ToplamTutar() => SiparisDetaylar.Sum(sd => sd.Tutar());
        //public decimal ToplamTutar()
        //{
        //    decimal toplam = 0;
        //    foreach (SiparisDetay detay in SiparisDetaylar)
        //    {
        //        toplam += detay.Tutar();
        //    }
        //    return toplam;
        //}
    }
}
