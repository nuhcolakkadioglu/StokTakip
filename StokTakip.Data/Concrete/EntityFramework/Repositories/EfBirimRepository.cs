using Microsoft.EntityFrameworkCore;
using StokTakip.Core.Data.Concrete.EntityFramework;
using StokTakip.Data.Abstract;
using StokTakip.Entities.Concrete;

namespace StokTakip.Data.Concrete.EntityFramework.Repositories
{
    public class EfBirimRepository : EfEntityRepositoryBase<Birim>, IBirimRepository
    {
        public EfBirimRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
