using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryTransferencia : RepositoryBase<Transferencia>, IRepositoryTransferencia
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryTransferencia(MySqlContext mySqlContext) : base(mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }

        public override IEnumerable<Transferencia> GetAll()
        {
            return mySqlContext.transferencias.Include(j => j.TimeOrigem).Include(j => j.TimeDestino).Include(j => j.Jogador).ToList();
        }

        public Transferencia GetById(int id)
        {
            return mySqlContext.transferencias.Include(j => j.TimeOrigem).Include(j => j.TimeDestino).Include(j => j.Jogador).FirstOrDefault(x => x.Id == id);
        }
    }
}