using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Domain.Services
{
    public class ServiceTorneio : ServiceBase<Torneio>, IServiceTorneio
    {
        private readonly IRepositoryTorneio repositoryTorneio;

        public ServiceTorneio(IRepositoryTorneio repositoryTorneio) : base(repositoryTorneio)
        {
            this.repositoryTorneio = repositoryTorneio;
        }

        public void AddTime(TorneioTime obj)
        {
            repositoryTorneio.AddTime(obj);
        }
    }
}