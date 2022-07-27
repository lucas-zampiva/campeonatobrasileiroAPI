using CampeonatoBrasileiro.Application.Dtos;
using CampeonatoBrasileiro.Application.Interfaces.Mappers;
using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Mappers
{
    public class MapperTransferencia : IMapperTransferencia
    {
        public Transferencia MapperDtoToEntityCreate(TransferenciaDtoCreate transferenciaDTO)
        {
            var transferencia = new Transferencia()
            {
                TimeDestinoId = transferenciaDTO.TimeDestinoId,
                TimeOrigemId = transferenciaDTO.TimeOrigemId,
                JogadorId = transferenciaDTO.JogadorId,
                Data = transferenciaDTO.Data,
                Valor = transferenciaDTO.Valor
            };

            return transferencia;
        }

        public Transferencia MapperDtoToEntityUpdate(TransferenciaDtoUpdate transferenciaDTO)
        {
            var transferencia = new Transferencia()
            {
                Id = transferenciaDTO.Id,
                TimeDestinoId = transferenciaDTO.TimeDestinoId,
                TimeOrigemId = transferenciaDTO.TimeOrigemId,
                JogadorId = transferenciaDTO.JogadorId,
                Data = transferenciaDTO.Data,
                Valor = transferenciaDTO.Valor
            };

            return transferencia;
        }

        public TransferenciaDto MapperEntityToDto(Transferencia transferencia)
        {
            var transferenciaDto = new TransferenciaDto()
            {
                Id = transferencia.Id,
                TimeDestino = transferencia.TimeDestino,
                TimeOrigem = transferencia.TimeOrigem,
                Jogador = transferencia.Jogador,
                Valor = transferencia.Valor,
                Data = transferencia.Data
            };
            return transferenciaDto;
        }

        public IEnumerable<TransferenciaDto> MapperListTransferenciasDto(IEnumerable<Transferencia> transferencias)
        {
            var dto = transferencias.Select(t => new TransferenciaDto
            {
                Id = t.Id,
                TimeDestino = t.TimeDestino,
                TimeOrigem = t.TimeOrigem,
                Jogador = t.Jogador,
                Data = t.Data,
                Valor = t.Valor
            });
            return dto;
        }
    }
}