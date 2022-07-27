namespace CampeonatoBrasileiro.Application.Dtos
{
    public class PartidaDtoCreate
    {
        public int NroPartida { get; set; }
        public int MandanteId { get; set; }
        public int VisitanteId { get; set; }
        public int TorneioId { get; set; }
    }
}