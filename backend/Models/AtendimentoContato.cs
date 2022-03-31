using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site.Models
{
    public class AtendimentoContato
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
    }
}
