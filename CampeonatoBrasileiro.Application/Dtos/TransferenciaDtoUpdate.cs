namespace CampeonatoBrasileiro.Application.Dtos
{
    public class TransferenciaDtoUpdate
    {
        public int Id { get; set; }
        public int TimeOrigemId { get; set; }
        public int TimeDestinoId { get; set; }
        public int JogadorId { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    }
}