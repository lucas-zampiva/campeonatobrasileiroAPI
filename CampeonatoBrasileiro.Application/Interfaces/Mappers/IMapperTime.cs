using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Interfaces.Mappers
{
    public interface IMapperTime
    {
        Time MapperDtoToEntity(TimeDto timeDTO);

        Time MapperDtoToEntityCreate(TimeDtoCreate timeDTO);

        IEnumerable<TimeDto> MapperListTimesDto(IEnumerable<Time> times);

        TimeDto MapperEntityToDto(Time time);
    }
}