using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Interfaces.Mappers
{
    public interface IMapperEvento
    {
        Evento MapperDtoToEntityCreate(EventoDto eventoDto);
    }
}