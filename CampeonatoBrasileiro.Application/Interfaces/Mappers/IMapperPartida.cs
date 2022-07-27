using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro.Application.Interfaces.Mappers
{
    public interface IMapperPartida
    {
        Partida MapperDtoToEntityCreate(PartidaDtoCreate partidaDTO);

        Partida MapperDtoToEntityUpdate(PartidaDtoUpdate partidaDTO);

        IEnumerable<PartidaDto> MapperListPartidasDto(IEnumerable<Partida> partidas);

        PartidaDto MapperEntityToDto(Partida partida);
    }
}