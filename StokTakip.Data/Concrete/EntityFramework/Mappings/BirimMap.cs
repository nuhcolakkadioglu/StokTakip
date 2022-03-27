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
    public class BirimMap : IEntityTypeConfiguration<Birim>
    {
        public void Configure(EntityTypeBuilder<Birim> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Adi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Aciklama).HasMaxLength(75);
        }
    }
}
