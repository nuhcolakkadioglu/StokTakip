using Microsoft.EntityFrameworkCore;
using StokTakip.Data.Concrete.EntityFramework.Mappings;
using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Concrete.EntityFramework.Contexts
{
    public class StokTakipContext : DbContext
    {
        public StokTakipContext(DbContextOptions<StokTakipContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BirimMap());
            modelBuilder.ApplyConfiguration(new KategoriMap());
            modelBuilder.ApplyConfiguration(new MarkaMap());
            modelBuilder.ApplyConfiguration(new MusteriMap());
            modelBuilder.ApplyConfiguration(new SatisMap());
            modelBuilder.ApplyConfiguration(new SepetMap());
            modelBuilder.ApplyConfiguration(new UrunMap());
        }
        public DbSet<Birim> Birim { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Satis> Satis { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<Urun> Urun { get; set; }
    }
}
