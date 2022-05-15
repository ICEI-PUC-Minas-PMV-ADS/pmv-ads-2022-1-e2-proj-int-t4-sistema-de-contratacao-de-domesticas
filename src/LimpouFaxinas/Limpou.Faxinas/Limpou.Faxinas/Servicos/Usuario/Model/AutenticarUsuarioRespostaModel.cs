using Limpou.Faxinas.Entidades;

namespace Limpou.Faxinas.Servicos.Usuario.Model
{
    public class AutenticarUsuarioRespostaModel : RespostaServicoBase
    {
        public AutenticarUsuarioRespostaModel(UsuarioEntidade usuarioLogado) : base()
        {
            UsuarioLogado = usuarioLogado;
        }

        public AutenticarUsuarioRespostaModel(string mensagemFalha) : base(mensagemFalha) { }
        public UsuarioEntidade UsuarioLogado { get; }
    }
}
