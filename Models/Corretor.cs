using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuddenAmbiente.Models
{
    [Table("Corretor")]
    public class Corretor
    {
        [Key]
        [Display(Name = "ID do Corretor")]
        public int IdCorretor { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Nome do corretor")]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Email do corretor")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Senha do corretor")]
        public string Senha { get; set; }

    }
}
