using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro.Application
{
    public class ApplicationServiceEvento : IApplicationServiceEvento
    {
        private readonly IServiceEvento serviceEvento;
        private readonly IMapperEvento mapperEvento;

        public ApplicationServiceEvento(IServiceEvento serviceEvento, IMapperEvento mapperEvento)
        {
            this.serviceEvento = serviceEvento;
            this.mapperEvento = mapperEvento;
        }

        public void Add(EventoDto eventoDto)
        {
            var evento = mapperEvento.MapperDtoToEntityCreate(eventoDto);
            serviceEvento.Add(evento);
        }
    }
}