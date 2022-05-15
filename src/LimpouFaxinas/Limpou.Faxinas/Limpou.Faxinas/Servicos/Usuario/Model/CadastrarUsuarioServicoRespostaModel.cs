namespace Limpou.Faxinas.Servicos.Usuario.Model
{
    public class CadastrarUsuarioServicoRespostaModel : RespostaServicoBase
    {
        public CadastrarUsuarioServicoRespostaModel(int codigoUsuarioCadastrado) : base()
        {
            CodigoUsuarioCadastrado = codigoUsuarioCadastrado;
        }

        public CadastrarUsuarioServicoRespostaModel(string mensagemErro) : base(mensagemErro) { }

        public int CodigoUsuarioCadastrado { get; }
    }
}
