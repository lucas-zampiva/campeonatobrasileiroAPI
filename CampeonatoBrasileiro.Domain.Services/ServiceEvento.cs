using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Domain.Services
{
    public class ServiceEvento : ServiceEventoBase<Evento>, IServiceEvento
    {
        private readonly IRepositoryEvento repositoryEvento;

        public ServiceEvento(IRepositoryEvento repositoryEvento) : base(repositoryEvento)
        {
            this.repositoryEvento = repositoryEvento;
        }
    }
}