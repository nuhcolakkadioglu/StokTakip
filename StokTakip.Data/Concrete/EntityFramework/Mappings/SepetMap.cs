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
    public class SepetMap : IEntityTypeConfiguration<Sepet>
    {
        public void Configure(EntityTypeBuilder<Sepet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UrunAdi).IsRequired().HasMaxLength(150);
            builder.Property(x => x.BarkodNo).IsRequired().HasMaxLength(20);
            builder.Property(x => x.AlisFiyati).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.SatisFiyati).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.ToplamFiyat).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.Miktar).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.Kdv).IsRequired();
            builder.Property(x => x.KategoriId).IsRequired();
            builder.Property(x => x.UrunId).IsRequired();
            builder.Property(x => x.MarkaId).IsRequired();
            builder.Property(x => x.BirimId).IsRequired();

            builder.HasOne<Kategori>(m=>m.Kategori).WithMany(m=>m.Sepetler).HasForeignKey(m=>m.KategoriId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Urun>(m => m.Urun).WithMany(m => m.Sepetler).HasForeignKey(m => m.KategoriId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Marka>(m => m.Marka).WithMany(m => m.Sepetler).HasForeignKey(m => m.KategoriId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Birim>(m => m.Birim).WithMany(m => m.Sepetler).HasForeignKey(m => m.KategoriId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
