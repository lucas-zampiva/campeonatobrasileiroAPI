namespace CampeonatoBrasileiro.Domain.Entitys
{
    public class Evento : Base
    {
        public enum EventoTipo
        {
            Inicio,
            Gol,
            Intervalo,
            Acrescimo,
            Substituicao,
            Advertencia,
            Fim
        }

        public string Mensagem { get; set; }
        public DateTime Data { get; set; }
        public EventoTipo TipoEvento { get; set; }
        public int TorneioId { get; set; }
        public Torneio Torneio { get; set; }
        public int PartidaId { get; set; }
        public Partida Partida { get; set; }
    }
}