namespace CampeonatoBrasileiro.Domain.Entitys
{
    public class Transferencia : Base
    {
        public int TimeOrigemId { get; set; }
        public int TimeDestinoId { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int JogadorId { get; set; }

        public Time TimeOrigem { get; set; }
        public Time TimeDestino { get; set; }
        public Jogador Jogador { get; set; }
    }
}