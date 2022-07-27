namespace CampeonatoBrasileiro.Domain.Core.Interfaces.Services
{
    public interface IServiceEventoBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
    }
}