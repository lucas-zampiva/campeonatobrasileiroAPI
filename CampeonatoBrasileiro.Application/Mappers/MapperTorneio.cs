using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Mappers
{
    public class MapperTorneio : IMapperTorneio
    {
        public Torneio MapperDtoToEntity(TorneioDto torneioDTO)
        {
            var torneio = new Torneio()
            {
                Id = torneioDTO.Id,
                DataFim = torneioDTO.DataFim,
                DataInicio = torneioDTO.DataInicio,
                Nome = torneioDTO.Nome
            };

            return torneio;
        }

        public TorneioTime MapperDtoToEntityAddTime(TorneioTimeDto torneioTimeDto)
        {
            var torneio = new TorneioTime()
            {
                TimeId = torneioTimeDto.TimeId,
                TorneioId = torneioTimeDto.TorneioId
            };

            return torneio;
        }

        public Torneio MapperDtoToEntityCreate(TorneioDtoCreate torneioDTO)
        {
            var torneio = new Torneio()
            {
                DataFim = torneioDTO.DataFim,
                DataInicio = torneioDTO.DataInicio,
                Nome = torneioDTO.Nome
            };

            return torneio;
        }

        public Torneio MapperDtoToEntityUpdate(TorneioDtoUpdate torneioDTO)
        {
            var torneio = new Torneio()
            {
                Id = torneioDTO.Id,
                DataFim = torneioDTO.DataFim,
                DataInicio = torneioDTO.DataInicio,
                Nome = torneioDTO.Nome
            };

            return torneio;
        }

        public TorneioDto MapperEntityToDto(Torneio torneio)
        {
            var torneioDto = new TorneioDto()
            {
                Id = torneio.Id,
                DataFim = torneio.DataFim,
                DataInicio = torneio.DataInicio,
                Nome = torneio.Nome
            };
            return torneioDto;
        }

        public IEnumerable<TorneioDto> MapperListTorneiosDto(IEnumerable<Torneio> torneios)
        {
            var dto = torneios.Select(t => new TorneioDto
            {
                Id = t.Id,
                Nome = t.Nome,
                DataFim = t.DataFim,
                DataInicio = t.DataInicio,
                Times = t.Times
            });
            return dto;
        }
    }
}