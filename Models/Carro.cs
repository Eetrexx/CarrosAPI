using System;
using System.Collections.Generic;

#nullable disable

namespace CarrosAPI.Models
{
    public partial class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Dono { get; set; }
        public string Cor { get; set; }
        public DateTime? DataAquisicao { get; set; }
    }
}
