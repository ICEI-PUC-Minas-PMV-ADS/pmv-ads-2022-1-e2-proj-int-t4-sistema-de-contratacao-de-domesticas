using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Xunit;

namespace Limpou_Faxinas.Models
{
    [Table("serviços")]
    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }

        [Required(ErrorMessage = "Obrigatório descrever a data do serviço ")]
        public DateTime DataHora { get; set; }

        [Required(ErrorMessage = "Obrigatório agendar o serviço ")]
        public Boolean Agendar { get; set; }

        [Required(ErrorMessage = "Obrigatório descrever o tipo do serviço ")]
        public int tipoDeServico { get; set; }

        [Required(ErrorMessage = "Obrigatório descrever o serviço ")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {20} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {200} caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço do serviço")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2")]
        //Para definir o valor mínimo e máximo
        [Range(100,300, ErrorMessage = "O preço deve estar entre 100 e 300 reais")]
        public Decimal Preco { get; set; }

        public string ImagemUrl { get; set; }


        public bool DataDisponibilidade { get; set; }

        public List<Usuario> Usuarios { get; set; }


        //Codigo do Professor
        //public Dbset<Serviço> Serviços { get; set; }


    }
}
