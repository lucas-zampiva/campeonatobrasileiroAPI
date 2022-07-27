using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryPartida : RepositoryBase<Partida>, IRepositoryPartida
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryPartida(MySqlContext mySqlContext) : base(mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }

        public override IEnumerable<Partida> GetAll()
        {
            return mySqlContext.partidas.Include(j => j.Mandante).Include(j => j.Visitante).Include(j => j.Torneio).ToList();
        }
    }
}