using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryJogador : RepositoryBase<Jogador>, IRepositoryJogador
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryJogador(MySqlContext mySqlContext) : base(mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }
    }
}