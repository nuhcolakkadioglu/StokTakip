using Microsoft.EntityFrameworkCore;
using StokTakip.Core.Data.Concrete.EntityFramework;
using StokTakip.Data.Abstract;
using StokTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Concrete.EntityFramework.Repositories
{
    public class EfKategoriRepository : EfEntityRepositoryBase<Kategori>, IKategoriRepository
    {
        public EfKategoriRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
