using StokTakip.Data.Abstract;
using StokTakip.Data.Concrete.EntityFramework.Contexts;
using StokTakip.Data.Concrete.EntityFramework.Repositories;

namespace StokTakip.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StokTakipContext _context;
        private EfBirimRepository _birimRepository;
        private EfKategoriRepository _kategoriRepository;
        public UnitOfWork(StokTakipContext context)
        {
            _context = context;
        }

        public IBirimRepository Birim => _birimRepository ?? new EfBirimRepository(_context);
        public IKategoriRepository Kategori => _kategoriRepository ?? new EfKategoriRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
