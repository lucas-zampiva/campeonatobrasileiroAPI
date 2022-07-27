namespace CampeonatoBrasileiro.Application.Dtos
{
    public class JogadorDtoUpdate
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Pais { get; set; }
        public int TimeId { get; set; }
    }
}