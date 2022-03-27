using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StokTakip.Entities.Concrete;

namespace StokTakip.Data.Concrete.EntityFramework.Mappings
{
    public class SatisMap : IEntityTypeConfiguration<Satis>
    {
        public void Configure(EntityTypeBuilder<Satis> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BarkodNo).IsRequired().HasMaxLength(20);
            builder.Property(x => x.BirimFiyat).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.Miktar).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.ToplamFiyat).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.Kdv).IsRequired();
            builder.Property(x => x.BirimId).IsRequired();
            builder.Property(x => x.UrunId).IsRequired();
            builder.Property(x => x.SepetId).IsRequired();
        }
    }
}
