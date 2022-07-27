using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro.Application.Mappers
{
    public class MapperEvento : IMapperEvento
    {
        public Evento MapperDtoToEntityCreate(EventoDto eventoDto)
        {
            var evento = new Evento()
            {
                Mensagem = eventoDto.Mensagem,
                Data = eventoDto.Data,
                PartidaId = eventoDto.PartidaId,
                TorneioId = eventoDto.TorneioId,
                TipoEvento = eventoDto.TipoEvento,
            };

            return evento;
        }
    }
}