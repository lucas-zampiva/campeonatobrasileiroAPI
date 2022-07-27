﻿namespace CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(int id);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}