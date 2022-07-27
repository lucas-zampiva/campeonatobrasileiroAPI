using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Domain.Services
{
    public class ServiceTransferencia : ServiceBase<Transferencia>, IServiceTransferencia
    {
        private readonly IRepositoryTransferencia repositoryTransferencia;

        public ServiceTransferencia(IRepositoryTransferencia repositoryTransferencia) : base(repositoryTransferencia)
        {
            this.repositoryTransferencia = repositoryTransferencia;
        }
    }
}