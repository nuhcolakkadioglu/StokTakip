using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StokTakip.Entities.Concrete;

namespace StokTakip.Data.Concrete.EntityFramework.Mappings
{
    public class UrunMap : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UrunAdi).IsRequired().HasMaxLength(150);
            builder.Property(x => x.BarkodNo).IsRequired().HasMaxLength(20);
            builder.Property(x => x.AlisFiyati).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.SatisFiyati).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.Kdv).IsRequired();
            builder.Property(x => x.MarkaId).IsRequired();
            builder.Property(x => x.BirimId).IsRequired();
            builder.Property(x => x.KategoriId).IsRequired();

            builder.HasOne<Marka>(m => m.Marka).WithMany(m => m.Urunler).HasForeignKey(m => m.MarkaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Kategori>(m => m.Kategori).WithMany(m => m.Urunler).HasForeignKey(m => m.KategoriId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Birim>(m => m.Birim).WithMany(m => m.Urunler).HasForeignKey(m => m.BirimId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
