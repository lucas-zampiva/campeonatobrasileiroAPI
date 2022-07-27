using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryJogador : RepositoryBase<Jogador>, IRepositoryJogador
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryJogador(MySqlContext mySqlContext) : base(mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }

        public override IEnumerable<Jogador> GetAll()
        {
            return mySqlContext.jogadores.Include(j => j.Time).ToList();
        }

        public Jogador GetById(int id)
        {
            return mySqlContext.jogadores.Include(j => j.Time).FirstOrDefault(x => x.Id == id);
        }
    }
}