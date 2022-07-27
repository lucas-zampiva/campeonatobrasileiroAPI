using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryEventoBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
    }
}