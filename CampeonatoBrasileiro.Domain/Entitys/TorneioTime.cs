using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoBrasileiro.Domain.Entitys
{
    public class TorneioTime
    {
        public int TorneioId { get; set; }
        public Torneio Torneio { get; set; }
        public int TimeId { get; set; }
        public Time Time { get; set; }

    }
}
