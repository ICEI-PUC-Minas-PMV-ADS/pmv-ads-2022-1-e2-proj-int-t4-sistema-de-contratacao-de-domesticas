using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Limpou_Faxinas.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório cadastrar CPF")]
        public string CPF { get; set; }

        public Perfil Perfil {get; set; }
    }

    public enum Perfil 
    {
        Admin,
        Colaborador,
        Empregador
    }
      
}
