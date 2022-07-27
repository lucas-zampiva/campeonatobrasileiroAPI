using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Mappers
{
    public class MapperPartida : IMapperPartida
    {
        public Partida MapperDtoToEntityCreate(PartidaDtoCreate partidaDTO)
        {
            var partida = new Partida()
            {
                NroPartida = partidaDTO.NroPartida,
                MandanteId = partidaDTO.MandanteId,
                VisitanteId = partidaDTO.VisitanteId,
                TorneioId = partidaDTO.TorneioId
            };

            return partida;
        }

        public Partida MapperDtoToEntityUpdate(PartidaDtoUpdate partidaDTO)
        {
            var partida = new Partida()
            {
                Id = partidaDTO.Id,
                NroPartida = partidaDTO.NroPartida,
                MandanteId = partidaDTO.MandanteId,
                VisitanteId = partidaDTO.VisitanteId,
                TorneioId = partidaDTO.TorneioId
            };

            return partida;
        }

        public PartidaDto MapperEntityToDto(Partida partida)
        {
            var partidaDto = new PartidaDto()
            {
                Id = partida.Id,
                NroPartida = partida.NroPartida,
                Mandante = partida.Mandante,
                Visitante = partida.Visitante,
                Torneio = partida.Torneio
            };
            return partidaDto;
        }

        public IEnumerable<PartidaDto> MapperListPartidasDto(IEnumerable<Partida> partidas)
        {
            var dto = partidas.Select(p => new PartidaDto
            {
                Id = p.Id,
                NroPartida = p.NroPartida,
                Mandante = p.Mandante,
                Visitante = p.Visitante,
                Torneio = p.Torneio
            });
            return dto;
        }
    }
}