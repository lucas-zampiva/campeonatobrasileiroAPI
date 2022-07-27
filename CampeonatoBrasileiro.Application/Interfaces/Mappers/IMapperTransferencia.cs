using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Interfaces.Mappers
{
    public interface IMapperTransferencia
    {
        Transferencia MapperDtoToEntityCreate(TransferenciaDtoCreate transferenciaDTO);

        Transferencia MapperDtoToEntityUpdate(TransferenciaDtoUpdate transferenciaDTO);

        IEnumerable<TransferenciaDto> MapperListTransferenciasDto(IEnumerable<Transferencia> transferencias);

        TransferenciaDto MapperEntityToDto(Transferencia transferencia);
    }
}