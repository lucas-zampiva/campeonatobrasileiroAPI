using CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace CampeonatoBrasileiro.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly MySqlContext mySqlContext;

        public RepositoryBase(MySqlContext mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                mySqlContext.Set<TEntity>().Add(obj);
                mySqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return mySqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return mySqlContext.Set<TEntity>().Find(id);
        }

        public void Remove(int id)
        {
            try
            {
                var obj = mySqlContext.Set<TEntity>().Find(id);
                if (obj != null)
                {
                    mySqlContext.Set<TEntity>().Remove(obj);
                    mySqlContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Entidade não encontrada");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                mySqlContext.Entry(obj).State = EntityState.Modified;
                mySqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}