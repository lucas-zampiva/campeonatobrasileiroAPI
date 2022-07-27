namespace CampeonatoBrasileiro.Domain.Entitys
{
    public class Torneio : Base
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ICollection<TorneioTime> Times { get; set; }
    }
}