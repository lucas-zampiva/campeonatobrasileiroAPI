namespace CampeonatoBrasileiro.Application.Dtos
{
    public class PartidaDtoUpdate
    {
        public int Id { get; set; }
        public int NroPartida { get; set; }
        public int MandanteId { get; set; }
        public int VisitanteId { get; set; }
        public int TorneioId { get; set; }
    }
}