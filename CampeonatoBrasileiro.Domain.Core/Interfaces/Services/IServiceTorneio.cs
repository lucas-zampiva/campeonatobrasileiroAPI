using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Domain.Core.Interfaces.Services
{
    public interface IServiceTorneio : IServiceBase<Torneio>
    {
        void AddTime(TorneioTime obj);
    }
}