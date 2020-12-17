using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuddenAmbiente.Models
{
    [Table("Interesse")]
    public class Interesse
    {

        [Key]
        [Display(Name = "ID do Interesse")]
        public int IdInteresse { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nome do possível inquilino")]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Contato do possível inquilino")]
        public string Contato { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Número de inscrição do primeiro imóvel")]
        public string InscricaoImovelUm { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Número de inscrição do segundo imóvel")]
        public string InscricaoImovelDois { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Número de inscrição do terceiro imóvel")]
        public string InscricaoImovelTres { get; set; }
    }
}
