using CampeonatoBrasileiro.Application.Dtos;

namespace CampeonatoBrasileiro.Application.Interfaces
{
    public interface IApplicationServiceJogador
    {
        void Add(JogadorDtoCreate jogadorDto);

        void Update(JogadorDtoUpdate jogadorDto);

        void Remove(int id);

        IEnumerable<JogadorDto> GetAll();

        JogadorDto GetById(int id);
    }
}