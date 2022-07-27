using CampeonatoBrasileiro.Domain.Entitys;

namespace CampeonatoBrasileiro.Application.Dtos
{
    public class TorneioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ICollection<TorneioTime> Times { get; set; }
    }
}