using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;

namespace CampeonatoBrasileiro.Application
{
    public class ApplicationServiceTime : IApplicationServiceTime
    {
        private readonly IServiceTime serviceTime;
        private readonly IMapperTime mapperTime;

        public ApplicationServiceTime(IServiceTime serviceTime, IMapperTime mapperTime)
        {
            this.serviceTime = serviceTime;
            this.mapperTime = mapperTime;
        }

        public void Add(TimeDtoCreate timeDto)
        {
            var time = mapperTime.MapperDtoToEntityCreate(timeDto);
            serviceTime.Add(time);
        }

        public IEnumerable<TimeDto> GetAll()
        {
            var times = serviceTime.GetAll();
            return mapperTime.MapperListTimesDto(times);
        }

        public TimeDto GetById(int id)
        {
            var time = serviceTime.GetById(id);
            return mapperTime.MapperEntityToDto(time);
        }

        public void Remove(int id)
        {
            serviceTime.Remove(id);
        }

        public void Update(TimeDto timeDto)
        {
            var time = mapperTime.MapperDtoToEntity(timeDto);
            serviceTime.Update(time);
        }
    }
}