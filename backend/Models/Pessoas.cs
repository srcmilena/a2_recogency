using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site.Models
{
    public class Pessoas
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Saída { get; set; } // O usuário digita
        public DateTime Retorno { get; set; }
        public double Preço { get; set; }
    }
}
