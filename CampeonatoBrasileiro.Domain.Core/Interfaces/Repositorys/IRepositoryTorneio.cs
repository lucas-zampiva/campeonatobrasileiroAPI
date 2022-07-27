using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryTorneio : IRepositoryBase<Torneio>
    {
        void AddTime(TorneioTime obj);
    }
}