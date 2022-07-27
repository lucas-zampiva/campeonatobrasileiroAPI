using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryEvento : RepositoryEventoBase<Evento>, IRepositoryEvento
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryEvento(MySqlContext mySqlContext) : base(mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }
    }
}