using CampeonatoBrasileiro.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro.Application.Interfaces
{
    public interface IApplicationServiceTorneio
    {
        void Add(TorneioDtoCreate torneioDto);

        void AddTime(TorneioTimeDto torneioDto);

        void Update(TorneioDtoUpdate torneioDto);

        void Remove(int id);

        IEnumerable<TorneioDto> GetAll();

        TorneioDto GetById(int id);
    }
}