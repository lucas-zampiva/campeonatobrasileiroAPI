using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Domain.Services
{
    public class ServicePartida : ServiceBase<Partida>, IServicePartida
    {
        private readonly IRepositoryPartida repositoryPartida;

        public ServicePartida(IRepositoryPartida repositoryPartida) : base(repositoryPartida)
        {
            this.repositoryPartida = repositoryPartida;
        }
    }
}