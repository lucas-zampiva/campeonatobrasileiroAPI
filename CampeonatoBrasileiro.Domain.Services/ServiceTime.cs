using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Domain.Services
{
    public class ServiceTime : ServiceBase<Time>, IServiceTime
    {
        private readonly IRepositoryTime repositoryTime;

        public ServiceTime(IRepositoryTime repositoryTime) : base(repositoryTime)
        {
            this.repositoryTime = repositoryTime;
        }
    }
}