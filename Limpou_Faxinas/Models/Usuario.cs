using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Limpou_Faxinas.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "Informar Usuário ")]
        public int UsuarioId { get; set; }

        [StringLength(70, ErrorMessage = "O tamanho máximo é de 70 caracteres")]
        [Required(ErrorMessage = "Informe o nome do usuário")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do usuário")]
        public string Endereco { get; set; }

        [StringLength(11, ErrorMessage = "O tamanho máximo é de 11 caracteres")]
        [Required(ErrorMessage = "Insira o CPF do usuário")]
        public string CPF { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        [Required(ErrorMessage = "Informe o nome do usuário")]
        public int Avaliacao { get; set; }

        [StringLength(12, ErrorMessage = "O tamanho máximo é de 12 caracteres")]
        [Required(ErrorMessage = "Insira a senha")]
        public string Senha { get; set; }

        //Um usuario pode cadastrar vários serviços

        [Required(ErrorMessage = "Informe o preço do serviço")]
        public int ServicoId { get; set; }

        [Required(ErrorMessage = "Informe o preço do serviço")]
        public virtual Servico Servico { get; set; }
    }
}
