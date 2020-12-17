using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuddenAmbiente.Models
{
    [Table("Inquilino")]
    public class Inquilino
    {
        [Key]
        [Display(Name = "ID do Inquilino")]
        public int IdCorretor { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Nome do corretor")]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        [Display(Name = "Contato do corretor")]
        public string Contato { get; set; }
    }
}
