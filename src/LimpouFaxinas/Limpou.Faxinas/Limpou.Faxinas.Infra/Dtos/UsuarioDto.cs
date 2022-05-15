namespace Limpou.Faxinas.Infra.Dtos
{
    public class UsuarioDto
    {
        public int Codigo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string NumeroTelefone { get; set; }
        public int Perfil { get; set; }
        public int? CodigoEndereco { get; set; }
        public string ChaveIdentificacaoEndereco { get; set; }
        public string CepEndereco { get; set; }
        public string LocalidadeEndereco { get; set; }
        public string LogradouroEndereco { get; set; }
        public string NumeroEndereco { get; set; }
        public string ComplementoEndereco { get; set; }
        public string BairroEndereco { get; set; }
        public string UfEndereco { get; set; }
    }
}
