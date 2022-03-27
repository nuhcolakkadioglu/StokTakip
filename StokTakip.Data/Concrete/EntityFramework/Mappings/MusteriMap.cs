using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Concrete.EntityFramework.Mappings
{
    public class MusteriMap : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AdSoyad).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Telefon).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Adres).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Resim).HasMaxLength(225);
            builder.Property(x => x.Aciklama).HasMaxLength(75);
            builder.Property(x => x.Puan).HasPrecision(5, 2);

        }
    }
}
