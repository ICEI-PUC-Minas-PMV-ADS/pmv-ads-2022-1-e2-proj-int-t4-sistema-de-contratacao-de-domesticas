using Limpou.Faxinas.Entidades;

namespace Limpou.Faxinas.Servicos.Usuario.Model
{
    public class ObterUsuarioServicoRespostaModel : RespostaServicoBase
    {
        public ObterUsuarioServicoRespostaModel(UsuarioEntidade usuario) : base()
        {
            Usuario = usuario;
        }

        public ObterUsuarioServicoRespostaModel(string mensagemFalha) : base(mensagemFalha)
        {
            Usuario = null;
        }

        public UsuarioEntidade Usuario { get; }
    }
}
