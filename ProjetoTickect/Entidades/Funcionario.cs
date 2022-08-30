using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTickect.Entidades
{
    [Table("Funcionario", Schema = "public")]
    public class Funcionario
    {
        [Key]
        public int id { get; set; }
        
        [Required(ErrorMessage ="O nome deve ser informado")]
        [Display(Name ="Nome Funcionário")]
        [MinLength(3, ErrorMessage = "Nome deve ser maior que 3 caracteres")]
        [MaxLength(100, ErrorMessage = "Nome deve ser menor que 100 caracteres")]
        public string nome { get; set; }

        [Required(ErrorMessage ="O cpf deve ser informado")]
        [Display(Name = "CPF Funcionário")]
        public string cpf { get; set; }

        [Display(Name = "Telefone Funcionário")]
        public string fone { get; set; }

        [Display(Name = "Data de inclussão")]
        public DateTime dtInclusao { get; set; }

        [Display(Name = "Data de Alteração")]
        public DateTime dtAlteracao { get; set; }

        [Required]
        public string AtivoInativo { get; set; }
    }
}
