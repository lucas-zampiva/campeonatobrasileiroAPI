using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Mappers
{
    public class MapperJogador : IMapperJogador
    {
        public Jogador MapperDtoToEntityCreate(JogadorDtoCreate jogadorDTO)
        {
            var jogador = new Jogador()
            {
                Nome = jogadorDTO.Nome,
                DataNascimento = jogadorDTO.DataNascimento,
                Pais = jogadorDTO.Pais,
                TimeId = jogadorDTO.TimeId
            };

            return jogador;
        }

        public Jogador MapperDtoToEntityUpdate(JogadorDtoUpdate jogadorDTO)
        {
            var jogador = new Jogador()
            {
                Id = jogadorDTO.Id,
                Nome = jogadorDTO.Nome,
                DataNascimento = jogadorDTO.DataNascimento,
                Pais = jogadorDTO.Pais,
                TimeId = jogadorDTO.TimeId
            };

            return jogador;
        }

        public JogadorDto MapperEntityToDto(Jogador jogador)
        {
            var jogadorDto = new JogadorDto()
            {
                Id = jogador.Id,
                Nome = jogador.Nome,
                DataNascimento = jogador.DataNascimento,
                Pais = jogador.Pais,
                Time = jogador.Time
            };
            return jogadorDto;
        }

        public IEnumerable<JogadorDto> MapperListJogadoresDto(IEnumerable<Jogador> jogadores)
        {
            var dto = jogadores.Select(j => new JogadorDto
            {
                Id = j.Id,
                Nome = j.Nome,
                DataNascimento = j.DataNascimento,
                Pais = j.Pais,
                Time = j.Time
            });
            return dto;
        }
    }
}