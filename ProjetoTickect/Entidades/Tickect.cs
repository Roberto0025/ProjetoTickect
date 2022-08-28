﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTickect.Entidades
{
    [Table("Tickect", Schema = "public")]
    public class Tickect
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "A data deve ser informada")]
        [Display(Name = "Data de entrega")]
        public string dtEntrega { get; set; }

        [Required]
        [Display(Name = "Número do tickect")]
        public int numerorTickect { get; set; }

        [Required]
        [Display(Name = "Funcionario")]
        public Funcionario funcionario { get; set; }
    }
}
