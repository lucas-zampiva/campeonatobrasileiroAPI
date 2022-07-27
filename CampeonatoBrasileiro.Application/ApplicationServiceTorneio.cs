using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;

namespace CampeonatoBrasileiro.Application
{
    public class ApplicationServiceTorneio : IApplicationServiceTorneio
    {
        private readonly IServiceTorneio serviceTorneio;
        private readonly IMapperTorneio mapperTorneio;

        public ApplicationServiceTorneio(IServiceTorneio serviceTorneio, IMapperTorneio mapperTorneio)
        {
            this.serviceTorneio = serviceTorneio;
            this.mapperTorneio = mapperTorneio;
        }

        public void Add(TorneioDtoCreate torneioDto)
        {
            var torneio = mapperTorneio.MapperDtoToEntityCreate(torneioDto);
            serviceTorneio.Add(torneio);
        }

        public void AddTime(TorneioTimeDto torneioDto)
        {
            var torneio = mapperTorneio.MapperDtoToEntityAddTime(torneioDto);
            serviceTorneio.AddTime(torneio);
        }

        public IEnumerable<TorneioDto> GetAll()
        {
            var torneioes = serviceTorneio.GetAll();
            return mapperTorneio.MapperListTorneiosDto(torneioes);
        }

        public TorneioDto GetById(int id)
        {
            var torneio = serviceTorneio.GetById(id);
            return mapperTorneio.MapperEntityToDto(torneio);
        }

        public void Remove(int id)
        {
            serviceTorneio.Remove(id);
        }

        public void Update(TorneioDtoUpdate torneioDto)
        {
            var torneio = mapperTorneio.MapperDtoToEntityUpdate(torneioDto);
            serviceTorneio.Update(torneio);
        }
    }
}