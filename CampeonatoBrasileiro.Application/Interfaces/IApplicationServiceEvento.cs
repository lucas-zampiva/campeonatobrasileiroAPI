using CampeonatoBrasileiro.Application.Dtos;

namespace CampeonatoBrasileiro.Application.Interfaces
{
    public interface IApplicationServiceEvento
    {
        void Add(EventoDto eventoDto);
    }
}