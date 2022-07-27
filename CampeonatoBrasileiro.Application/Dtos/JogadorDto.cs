using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Dtos
{
    public class JogadorDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Pais { get; set; }
        public Time Time { get; set; }
    }
}