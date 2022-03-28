namespace StokTakip.Data.Abstract
{
    public interface IUnitOfWork
    {
        IBirimRepository Birim { get; }
        IKategoriRepository Kategori { get; }
        Task<int> SaveAsync();
    }
}
