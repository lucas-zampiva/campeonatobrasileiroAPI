using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Domain.Services
{
    public class ServiceJogador : ServiceBase<Jogador>, IServiceJogador
    {
        private readonly IRepositoryJogador repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador) : base(repositoryJogador)
        {
            this.repositoryJogador = repositoryJogador;
        }
    }
}