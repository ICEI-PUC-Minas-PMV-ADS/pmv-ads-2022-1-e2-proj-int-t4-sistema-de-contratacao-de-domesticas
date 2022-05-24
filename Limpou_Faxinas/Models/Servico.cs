using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required(ErrorMessage = "Obrigatório descrever o preço do serviço ")]
        public Decimal Preco { get; set; }

        [Required(ErrorMessage = "Obrigatório agendar o serviço ")]
        public Boolean Agendar { get; set; }

        [Required(ErrorMessage = "Obrigatório descrever o tipo do serviço ")]
        public int tipoDeServico { get; set; }

        [Required(ErrorMessage = "Obrigatório descrever o serviço ")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {20} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {200} caracteres")]
        public string Descricao { get; set; }

        [NotMapped]
        public List<Usuario> Usuarios { get; set; }

        
        
    }
}
