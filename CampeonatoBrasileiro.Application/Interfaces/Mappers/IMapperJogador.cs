using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Interfaces.Mappers
{
    public interface IMapperJogador
    {
        Jogador MapperDtoToEntityCreate(JogadorDtoCreate jogadorDTO);

        Jogador MapperDtoToEntityUpdate(JogadorDtoUpdate jogadorDTO);

        IEnumerable<JogadorDto> MapperListJogadoresDto(IEnumerable<Jogador> jogadores);

        JogadorDto MapperEntityToDto(Jogador jogador);
    }
}