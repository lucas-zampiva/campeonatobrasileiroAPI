using CampeonatoBrasileiro.Application.Dtos;

namespace CampeonatoBrasileiro.Application.Interfaces
{
    public interface IApplicationServicePartida
    {
        void Add(PartidaDtoCreate partidaDto);

        void Update(PartidaDtoUpdate partidaDto);

        void Remove(int id);

        IEnumerable<PartidaDto> GetAll();

        PartidaDto GetById(int id);
    }
}