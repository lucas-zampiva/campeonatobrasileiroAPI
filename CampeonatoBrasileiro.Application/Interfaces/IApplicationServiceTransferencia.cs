using CampeonatoBrasileiro.Application.Dtos;

namespace CampeonatoBrasileiro.Application.Interfaces
{
    public interface IApplicationServiceTransferencia
    {
        void Add(TransferenciaDtoCreate transferenciaDto);

        void Update(TransferenciaDtoUpdate transferenciaDto);

        void Remove(int id);

        IEnumerable<TransferenciaDto> GetAll();

        TransferenciaDto GetById(int id);
    }
}