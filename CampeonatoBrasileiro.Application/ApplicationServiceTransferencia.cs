using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro.Application
{
    public class ApplicationServiceTransferencia : IApplicationServiceTransferencia
    {
        private readonly IServiceTransferencia serviceTransferencia;
        private readonly IMapperTransferencia mapperTransferencia;

        public ApplicationServiceTransferencia(IServiceTransferencia serviceTransferencia, IMapperTransferencia mapperTransferencia)
        {
            this.serviceTransferencia = serviceTransferencia;
            this.mapperTransferencia = mapperTransferencia;
        }

        public void Add(TransferenciaDtoCreate transferenciaDto)
        {
            var transferencia = mapperTransferencia.MapperDtoToEntityCreate(transferenciaDto);
            serviceTransferencia.Add(transferencia);
        }

        public IEnumerable<TransferenciaDto> GetAll()
        {
            var transferencias = serviceTransferencia.GetAll();
            return mapperTransferencia.MapperListTransferenciasDto(transferencias);
        }

        public TransferenciaDto GetById(int id)
        {
            var transferencia = serviceTransferencia.GetById(id);
            return mapperTransferencia.MapperEntityToDto(transferencia);
        }

        public void Remove(int id)
        {
            serviceTransferencia.Remove(id);
        }

        public void Update(TransferenciaDtoUpdate transferenciaDto)
        {
            var transferencia = mapperTransferencia.MapperDtoToEntityUpdate(transferenciaDto);
            serviceTransferencia.Update(transferencia);
        }
    }
}