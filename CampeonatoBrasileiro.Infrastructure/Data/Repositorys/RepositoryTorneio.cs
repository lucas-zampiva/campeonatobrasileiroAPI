using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using CampeonatoBrasileiro.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryTorneio : RepositoryBase<Torneio>, IRepositoryTorneio
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryTorneio(MySqlContext mySqlContext) : base(mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }

        public override IEnumerable<Torneio> GetAll()
        {
            return mySqlContext.torneios.Select(t => new Torneio
            {
                Id = t.Id,
                Nome = t.Nome,
                DataInicio = t.DataInicio,
                DataFim = t.DataFim,
                Times = t.Times.Select(t => new TorneioTime
                {
                    Time = t.Time
                }).ToList()
            });
            //return mySqlContext.torneios.Include(j => j.Times).ToList();
        }

        public void AddTime(TorneioTime obj)
        {
            try
            {
                var time = mySqlContext.Set<Time>().Find(obj.TimeId);
                var torneio = mySqlContext.Set<Torneio>().Find(obj.TorneioId);
                var torneioTime = new TorneioTime
                {
                    Torneio = torneio,
                    Time = time
                };
                mySqlContext.Add(torneioTime);
                mySqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}