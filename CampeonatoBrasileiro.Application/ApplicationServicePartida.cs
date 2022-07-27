using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;

namespace CampeonatoBrasileiro.Application
{
    public class ApplicationServicePartida : IApplicationServicePartida
    {
        private readonly IServicePartida servicePartida;
        private readonly IMapperPartida mapperPartida;

        public ApplicationServicePartida(IServicePartida servicePartida, IMapperPartida mapperPartida)
        {
            this.servicePartida = servicePartida;
            this.mapperPartida = mapperPartida;
        }

        public void Add(PartidaDtoCreate partidaDto)
        {
            var partida = mapperPartida.MapperDtoToEntityCreate(partidaDto);
            servicePartida.Add(partida);
        }

        public IEnumerable<PartidaDto> GetAll()
        {
            var partidas = servicePartida.GetAll();
            return mapperPartida.MapperListPartidasDto(partidas);
        }

        public PartidaDto GetById(int id)
        {
            var partida = servicePartida.GetById(id);
            return mapperPartida.MapperEntityToDto(partida);
        }

        public void Remove(int id)
        {
            servicePartida.Remove(id);
        }

        public void Update(PartidaDtoUpdate partidaDto)
        {
            var partida = mapperPartida.MapperDtoToEntityUpdate(partidaDto);
            servicePartida.Update(partida);
        }
    }
}