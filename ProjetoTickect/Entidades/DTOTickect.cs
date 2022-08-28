using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTickect.Entidades
{
    public class DTOTickect
    {
        public int id { get; set; }
        public string dtEntrega { get; set; }
        public int numerorTickect { get; set; }
        public Funcionario funcionario { get; set; }
    }
}