namespace CampeonatoBrasileiro.Domain.Entitys
{
    public class Partida : Base
    {
        public int NroPartida { get; set; }
        public int MandanteId { get; set; }
        public int VisitanteId { get; set; }
        public int TorneioId { get; set; }
        public Time Mandante { get; set; }
        public Time Visitante { get; set; }
        public Torneio Torneio { get; set; }
    }
}