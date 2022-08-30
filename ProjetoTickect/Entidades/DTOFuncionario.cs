using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTickect.Entidades
{
    public class DTOFuncionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string fone { get; set; }
        public DateTime dtInclusao { get; set; }
        public DateTime dtAlteracao { get; set; }
        public string AtivoInativo { get; set; }
    }
}
