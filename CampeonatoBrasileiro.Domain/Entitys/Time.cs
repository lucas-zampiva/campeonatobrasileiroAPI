﻿namespace CampeonatoBrasileiro.Domain.Entitys
{
    public class Time : Base
    {
        public string Nome { get; set; }
        public string Localidade { get; set; }
        public ICollection<TorneioTime> Torneios { get; set; }
    }
}