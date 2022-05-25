using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Limpou_Faxinas.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [StringLength(70, ErrorMessage = "O tamanho máximo é de 70 caracteres")]
        [Required(ErrorMessage = "Informe o nome do usuário")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do usuário")]
        public string Endereco { get; set; }

        public int CPF { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        [Required(ErrorMessage = "Informe o nome do usuário")]
        public int Avaliacao { get; set; }


        //Um usuario pode cadastrar vários serviços
        
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }
    }
}
