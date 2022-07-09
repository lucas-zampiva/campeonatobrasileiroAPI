using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryTime : RepositoryBase<Time>, IRepositoryTime
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryTime(MySqlContext mySqlContext) : base(mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }
    }
}