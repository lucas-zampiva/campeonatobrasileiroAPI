using CampeonatoBrasileiro.Application.Dtos;

namespace CampeonatoBrasileiro.Application.Interfaces
{
    public interface IApplicationServiceTime
    {
        void Add(TimeDtoCreate timeDto);

        void Update(TimeDto timeDto);

        void Remove(int id);

        IEnumerable<TimeDto> GetAll();

        TimeDto GetById(int id);
    }
}