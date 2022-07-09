using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryTransferencia : RepositoryBase<Transferencia>, IRepositoryTransferencia
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryTransferencia(MySqlContext mySqlContext) : base(mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }
    }
}