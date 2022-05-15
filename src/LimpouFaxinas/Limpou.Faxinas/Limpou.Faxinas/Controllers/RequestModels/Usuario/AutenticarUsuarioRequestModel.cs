using System.Collections.Generic;
using System.Linq;

namespace Limpou.Faxinas.Controllers.RequestModels.Usuario
{
    public class AutenticarUsuarioRequestModel : IRequestModel
    {
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string PerfilUsuario { get; set; }

        public ValidacaoRequisicaoModel Validar()
        {
            var erros = new List<string>();

            if (string.IsNullOrWhiteSpace(EmailUsuario))
                erros.Add("O campo email do usuario deve ser preenchido");
            if (string.IsNullOrWhiteSpace(SenhaUsuario))
                erros.Add("O campo senha do usuario deve ser preenchido");
            if (string.IsNullOrWhiteSpace(PerfilUsuario))
                erros.Add("O campo tipo do usuario deve ser preenchido");

            return new ValidacaoRequisicaoModel { Erros = erros, Valido = !erros.Any() };
        }
    }
}
