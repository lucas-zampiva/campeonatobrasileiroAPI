using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Mappers
{
    public class MapperTime : IMapperTime
    {
        public Time MapperDtoToEntity(TimeDto timeDTO)
        {
            var time = new Time()
            {
                Id = timeDTO.Id,
                Nome = timeDTO.Nome,
                Localidade = timeDTO.Localidade,
            };

            return time;
        }

        public Time MapperDtoToEntityCreate(TimeDtoCreate timeDTO)
        {
            var time = new Time()
            {
                Nome = timeDTO.Nome,
                Localidade = timeDTO.Localidade,
            };

            return time;
        }

        public TimeDto MapperEntityToDto(Time time)
        {
            var timeDto = new TimeDto()
            {
                Id = time.Id,
                Nome = time.Nome,
                Localidade = time.Localidade,
            };
            return timeDto;
        }

        public IEnumerable<TimeDto> MapperListTimesDto(IEnumerable<Time> times)
        {
            var dto = times.Select(t => new TimeDto
            {
                Id = t.Id,
                Nome = t.Nome,
                Localidade = t.Localidade
            });
            return dto;
        }
    }
}