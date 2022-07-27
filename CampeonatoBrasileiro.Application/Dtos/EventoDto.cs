using static CampeonatoBrasileiro.Domain.Entitys.Evento;

namespace CampeonatoBrasileiro.Application.Dtos
{
    public class EventoDto
    {
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }
        public EventoTipo TipoEvento { get; set; }
        public int TorneioId { get; set; }
        public int PartidaId { get; set; }
    }
}