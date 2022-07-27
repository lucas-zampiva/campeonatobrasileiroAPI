using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Interfaces.Mappers
{
    public interface IMapperTorneio
    {
        Torneio MapperDtoToEntity(TorneioDto torneioDTO);

        Torneio MapperDtoToEntityCreate(TorneioDtoCreate torneioDTO);

        TorneioTime MapperDtoToEntityAddTime(TorneioTimeDto torneioTimeDto);

        Torneio MapperDtoToEntityUpdate(TorneioDtoUpdate torneioDTO);

        IEnumerable<TorneioDto> MapperListTorneiosDto(IEnumerable<Torneio> torneios);

        TorneioDto MapperEntityToDto(Torneio torneio);
    }
}