namespace StokTakip.Data.Abstract
{
    public interface IUnitOfWork
    {
        IBirimRepository Birim { get; }
        Task<int> SaveAsync();
    }
}
