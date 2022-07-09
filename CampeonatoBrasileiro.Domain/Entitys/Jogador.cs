namespace CampeonatoBrasileiro.Domain.Entitys
{
    public class Jogador : Base
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Pais { get; set; }
        public Time Time { get; set; }
    }
}