using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuddenAmbiente.Models
{
    [Table("Imovel")]
    public class Imovel
    {
        [Key]
        [Display(Name = "ID do Imovel")]
        public int IdImovel { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Número de inscrição do imóvel na prefeitura")]
        public string NumeroInscricao { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Link da imagem do imóvel")]
        public string Imagem { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Endereço do imóvel")]
        public string Endereco { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Tipo do imóvel")]
        public string Tipo { get; set; }

        [Column(TypeName = "varchar(2)")]
        [Display(Name = "Número de dormitórios do imóvel")]
        public string NumeroDormitorios { get; set; }

        [Column(TypeName = "varchar(2)")]
        [Display(Name = "Número de banheiros do imóvel")]
        public string NumeroBanheiros { get; set; }

        [Column(TypeName = "varchar(2)")]
        [Display(Name = "Número de vagas de garagem do imóvel")]
        public string NumeroVagasGaragem { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Número de banheiros do imóvel")]
        public string ValorAluguel { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Situação do imóvel")]
        public string Situacao { get; set; }
    }
}
