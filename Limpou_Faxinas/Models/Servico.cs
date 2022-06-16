using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace Limpou_Faxinas.Models
{
    [Table("serviços")]
    public class Servico
    {
        [Key]

        public int ServicoId { get; set; }

        
        [Required(ErrorMessage = "Obrigatório descrever o tipo do serviço ")]
        public string Demanda { get; set; }

        [Required(ErrorMessage = "Descreva a rua e numero do local de trabalho ")]
        public string Endereço{ get; set; }

        [Required(ErrorMessage = "Obrigatório descrever o bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatório descrever a cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o preço do serviço")]
        [Display(Name = "Preço")]       
        //Para definir o valor mínimo e máximo               
        public double Preco { get; set; }

              
     }
}
