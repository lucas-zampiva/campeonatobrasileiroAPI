using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;

namespace CampeonatoBrasileiro.Application
{
    public class ApplicationServiceJogador : IApplicationServiceJogador
    {
        private readonly IServiceJogador serviceJogador;
        private readonly IMapperJogador mapperJogador;

        public ApplicationServiceJogador(IServiceJogador serviceJogador, IMapperJogador mapperJogador)
        {
            this.serviceJogador = serviceJogador;
            this.mapperJogador = mapperJogador;
        }

        public void Add(JogadorDtoCreate jogadorDto)
        {
            var jogador = mapperJogador.MapperDtoToEntityCreate(jogadorDto);
            serviceJogador.Add(jogador);
        }

        public IEnumerable<JogadorDto> GetAll()
        {
            var jogadores = serviceJogador.GetAll();
            return mapperJogador.MapperListJogadoresDto(jogadores);
        }

        public JogadorDto GetById(int id)
        {
            var jogador = serviceJogador.GetById(id);
            return mapperJogador.MapperEntityToDto(jogador);
        }

        public void Remove(int id)
        {
            serviceJogador.Remove(id);
        }

        public void Update(JogadorDtoUpdate jogadorDto)
        {
            var jogador = mapperJogador.MapperDtoToEntityUpdate(jogadorDto);
            serviceJogador.Update(jogador);
        }
    }
}