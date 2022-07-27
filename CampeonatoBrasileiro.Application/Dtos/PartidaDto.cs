using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Dtos
{
    public class PartidaDto
    {
        public int Id { get; set; }
        public int NroPartida { get; set; }
        public Time Mandante { get; set; }
        public Time Visitante { get; set; }
        public Torneio Torneio { get; set; }
    }
}