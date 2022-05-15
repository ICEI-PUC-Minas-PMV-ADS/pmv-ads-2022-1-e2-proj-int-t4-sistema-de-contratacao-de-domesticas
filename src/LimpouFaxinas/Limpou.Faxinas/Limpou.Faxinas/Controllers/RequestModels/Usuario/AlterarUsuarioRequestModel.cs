using System.Collections.Generic;
using System.Linq;

namespace Limpou.Faxinas.Controllers.RequestModels.Usuario
{
    public class AlterarUsuarioRequestModel : IRequestModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string NumeroTelefone { get; set; }
        public string CepEndereco { get; set; }
        public string LocalidadeEndereco { get; set; }
        public string LogradouroEndereco { get; set; }
        public string NumeroEndereco { get; set; }
        public string ComplementoEndereco { get; set; }
        public string BairroEndereco { get; set; }
        public string UfEndereco { get; set; }

        public ValidacaoRequisicaoModel Validar()
        {
            var erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Senha) && Senha != null)
                erros.Add("A nova senha não é válida");
            if (string.IsNullOrWhiteSpace(Email) && Email != null)
                erros.Add("O novo email não é válido");
            if (string.IsNullOrWhiteSpace(Nome) && Nome != null)
                erros.Add("O novo nome não é válido");
            if (string.IsNullOrWhiteSpace(Cpf) && Cpf != null)
                erros.Add("O novo CPF não é válido");

            return new ValidacaoRequisicaoModel { Erros = erros, Valido = !erros.Any() };
        }
    }
}
