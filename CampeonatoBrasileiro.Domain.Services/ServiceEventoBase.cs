using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;

namespace CampeonatoBrasileiro.Domain.Services
{
    public class ServiceEventoBase<TEntity> : IServiceEventoBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryEventoBase<TEntity> repository;

        public ServiceEventoBase(IRepositoryEventoBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }
    }
}