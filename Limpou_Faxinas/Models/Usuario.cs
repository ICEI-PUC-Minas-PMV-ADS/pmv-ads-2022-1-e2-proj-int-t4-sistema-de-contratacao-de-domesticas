using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Limpou_Faxinas.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Avaliacao { get; set; }


        //Um usuario pode cadastrar vários serviços
        
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }
    }
}
