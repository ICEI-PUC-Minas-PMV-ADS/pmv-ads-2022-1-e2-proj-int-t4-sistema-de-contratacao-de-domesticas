using Limpou.Faxinas.Infra.Dtos;
using System;

namespace Limpou.Faxinas.Entidades
{
    public class UsuarioEntidade
    {
        public UsuarioEntidade(string email, string senha, string nome, string cpf, string numeroTelefone, int codigoPerfil, int? codigo = null)
        {
            Codigo = codigo.HasValue ? codigo.Value : 0;
            Email = email;
            Senha = senha;
            Nome = nome;
            Cpf = cpf;
            NumeroTelefone = numeroTelefone;
            CodigoPerfil = codigoPerfil;
        }

        public UsuarioEntidade(UsuarioDto usuarioDto)
        {
            Codigo = usuarioDto.Codigo;
            Email = usuarioDto.Email;
            Senha = usuarioDto.Senha;
            Nome = usuarioDto.Nome;
            Cpf = usuarioDto.Cpf;
            NumeroTelefone = usuarioDto.NumeroTelefone;
            CodigoPerfil = usuarioDto.Perfil;

            if (usuarioDto.CodigoEndereco.HasValue)
            {
                Endereco = new EnderecoEntidade
                {
                    Codigo = usuarioDto.CodigoEndereco.Value,
                    ChaveIdentificacao = usuarioDto.ChaveIdentificacaoEndereco,
                    Bairro = usuarioDto.BairroEndereco,
                    Cep = usuarioDto.CepEndereco,
                    Localidade = usuarioDto.LocalidadeEndereco,
                    Complemento = usuarioDto.ComplementoEndereco,
                    Logradouro = usuarioDto.LogradouroEndereco,
                    Numero = usuarioDto.NumeroEndereco,
                    Uf = usuarioDto.UfEndereco
                };
            }
        }

        public int Codigo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string NumeroTelefone { get; set; }
        public EnderecoEntidade Endereco { get; set; }

        public string Perfil
        {
            get
            {
                var a = (PerfilUsuario)this.CodigoPerfil;
                return a.ToString();
            }
            private set { }
        }

        private int CodigoPerfil { get; set; }

        public enum PerfilUsuario
        {
            CLIENTE = 1,
            FUNCIONARIO = 2,
        }

        public int ObterCodigoPerfil()
        {
            return (int)Enum.Parse<PerfilUsuario>(Perfil);
        }
    }
}
