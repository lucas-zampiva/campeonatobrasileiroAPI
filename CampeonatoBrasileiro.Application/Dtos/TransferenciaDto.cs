using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Dtos
{
    public class TransferenciaDto
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public Time TimeOrigem { get; set; }
        public Time TimeDestino { get; set; }
        public Jogador Jogador { get; set; }
    }
}