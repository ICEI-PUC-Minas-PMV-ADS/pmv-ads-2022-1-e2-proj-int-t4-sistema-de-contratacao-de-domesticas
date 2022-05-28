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

        
        [Required(ErrorMessage = "Obrigatório descrever o tipo do serviço ")]
        public string tipo_de_servico { get; set; }

        [Required(ErrorMessage = "Obrigatório descrever o serviço ")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço do serviço")]
        [Display(Name = "Preço")]       
        //Para definir o valor mínimo e máximo               
        public int Preco { get; set; }


        public List<Usuario> Usuarios { get; set; }


        //Codigo do Professor
        //public Dbset<Serviço> Serviços { get; set; }


    }
}
