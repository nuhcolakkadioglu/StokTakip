using StokTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class Musteri : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Resim { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Puan { get; set; }
        public string Aciklama { get; set; }
    }
}
