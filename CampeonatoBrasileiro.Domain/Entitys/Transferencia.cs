namespace CampeonatoBrasileiro.Domain.Entitys
{
    public class Transferencia
    {
        public Time TimeOrigem { get; set; }
        public Time TimeDestino { get; set; }
        public DateTime Data { get; set; }
        public decimal valor { get; set; }
    }
}