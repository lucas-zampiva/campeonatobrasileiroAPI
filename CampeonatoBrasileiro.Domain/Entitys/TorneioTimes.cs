using System.ComponentModel.DataAnnotations.Schema;

namespace CampeonatoBrasileiro.Domain.Entitys
{
    [Table("timetorneio")]
    public class TorneioTimes
    {
        public int TimesId { get; set; }
        public int TorneiosId { get; set; }
    }
}