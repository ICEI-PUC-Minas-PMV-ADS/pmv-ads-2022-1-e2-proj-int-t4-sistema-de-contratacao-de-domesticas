using Limpou.Faxinas.Controllers.RequestModels.Usuario;
using Limpou.Faxinas.Criptografia;
using Limpou.Faxinas.Entidades;
using Limpou.Faxinas.Infra.Dtos;
using Limpou.Faxinas.Infra.Repositorios;
using Limpou.Faxinas.Servicos.Usuario.Model;
using System;
using System.Threading.Tasks;
using static Limpou.Faxinas.Infra.Constantes.AppConstants;

namespace Limpou.Faxinas.Servicos.Usuario
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<AtualizarUsuarioServicoRespostaModel> AtualizarUsuario(int codigoUsuario, AlterarUsuarioRequestModel novosDadosUsuario)
        {
            if (novosDadosUsuario.Email != null)
            {
                var validarEmail = await ObterUsuario(novosDadosUsuario.Email);
                if (validarEmail.Sucesso && validarEmail.Usuario.Codigo != codigoUsuario)
                    return new AtualizarUsuarioServicoRespostaModel("Não foi possível salvar pois o novo email já é utilizado por outro usuário.");
            }

            var respostaObterUsuario = await ObterUsuario(codigoUsuario);
            if (!respostaObterUsuario.Sucesso)
                return new AtualizarUsuarioServicoRespostaModel("Usuário especificado não encontrado");

            var usuario = respostaObterUsuario.Usuario;
            var senha = string.IsNullOrEmpty(novosDadosUsuario.Senha) ? usuario.Senha : CifrarSenhaUsuario(novosDadosUsuario.Senha);
            var usuarioDto = new UsuarioDto()
            {
                Codigo = usuario.Codigo,
                Email = string.IsNullOrEmpty(novosDadosUsuario.Email) ? usuario.Email : novosDadosUsuario.Email,
                Senha = senha,
                Nome = string.IsNullOrEmpty(novosDadosUsuario.Nome) ? usuario.Nome : novosDadosUsuario.Nome,
                Cpf = string.IsNullOrEmpty(novosDadosUsuario.Cpf) ? usuario.Cpf : novosDadosUsuario.Cpf,
                NumeroTelefone = string.IsNullOrEmpty(novosDadosUsuario.NumeroTelefone) ? usuario.NumeroTelefone : novosDadosUsuario.NumeroTelefone,
                BairroEndereco = string.IsNullOrEmpty(novosDadosUsuario.BairroEndereco) ? usuario.Endereco.Bairro : novosDadosUsuario.BairroEndereco,
                CepEndereco = string.IsNullOrEmpty(novosDadosUsuario.CepEndereco) ? usuario.Endereco.Cep : novosDadosUsuario.CepEndereco,
                ComplementoEndereco = string.IsNullOrEmpty(novosDadosUsuario.ComplementoEndereco) ? usuario.Endereco.Complemento : novosDadosUsuario.ComplementoEndereco,
                LogradouroEndereco = string.IsNullOrEmpty(novosDadosUsuario.LogradouroEndereco) ? usuario.Endereco.Logradouro : novosDadosUsuario.LogradouroEndereco,
                NumeroEndereco = string.IsNullOrEmpty(novosDadosUsuario.NumeroEndereco) ? usuario.Endereco.Numero : novosDadosUsuario.NumeroEndereco,
                UfEndereco = string.IsNullOrEmpty(novosDadosUsuario.UfEndereco) ? usuario.Endereco.Uf : novosDadosUsuario.UfEndereco,
                LocalidadeEndereco = string.IsNullOrEmpty(novosDadosUsuario.LocalidadeEndereco) ? usuario.Endereco.Localidade : novosDadosUsuario.LocalidadeEndereco
            };

            await _usuarioRepositorio.AtualizarUsuario(usuarioDto);
            return new AtualizarUsuarioServicoRespostaModel();
        }

        public async Task<AutenticarUsuarioRespostaModel> AutenticarUsuario(string emailLogin, string senhaLogin, string perfilLogin)
        {
            var respostaObterUsuario = await ObterUsuario(emailLogin);

            if (!respostaObterUsuario.Sucesso)
                return new AutenticarUsuarioRespostaModel("Não existe usuário cadastrado para este E-mail.");
            if (!string.Equals(respostaObterUsuario.Usuario.Perfil, perfilLogin))
                return new AutenticarUsuarioRespostaModel("Falha ao logar com o perfil especificado");

            var usuario = respostaObterUsuario.Usuario;
            var senhaCadastrada = usuario.Senha;
            var senhaLogincifrada = CifrarSenhaUsuario(senhaLogin);

            if (!string.Equals(senhaCadastrada, senhaLogincifrada))
                return new AutenticarUsuarioRespostaModel("Senha Inválida");

            return new AutenticarUsuarioRespostaModel(usuario);
        }

        public async Task<CadastrarUsuarioServicoRespostaModel> CadastrarUsuario(UsuarioEntidade usuario)
        {
            var respostaObterUsuario = await ObterUsuario(usuario.Email);

            if (respostaObterUsuario.Sucesso)
                return new CadastrarUsuarioServicoRespostaModel("Nome de usuário já utilizado.");

            var chaveIdentificacaoEndereco = Guid.NewGuid().ToString();
            var senhaCifrada = CifrarSenhaUsuario(usuario.Senha);
            var usuarioDto = new UsuarioDto
            {
                Cpf = usuario.Cpf,
                Email = usuario.Email,
                Nome = usuario.Nome,
                NumeroTelefone = usuario.NumeroTelefone,
                Perfil = usuario.ObterCodigoPerfil(),
                Senha = senhaCifrada,
                ChaveIdentificacaoEndereco = chaveIdentificacaoEndereco,
                CepEndereco = usuario.Endereco?.Cep,
                BairroEndereco = usuario.Endereco?.Bairro,
                ComplementoEndereco = usuario.Endereco?.Complemento,
                LogradouroEndereco = usuario.Endereco?.Logradouro,
                NumeroEndereco = usuario.Endereco?.Numero,
                UfEndereco = usuario.Endereco?.Uf,
                LocalidadeEndereco = usuario.Endereco?.Localidade
            };

            await _usuarioRepositorio.CadastrarUsuario(usuarioDto);

            respostaObterUsuario = await ObterUsuario(usuario.Email);
            return new CadastrarUsuarioServicoRespostaModel(respostaObterUsuario.Usuario.Codigo);
        }

        public async Task<ObterUsuarioServicoRespostaModel> ObterUsuario(string emailUsuario)
        {
            var usuarioDto = await _usuarioRepositorio.ObterUsuario(emailUsuario);

            if (usuarioDto == null)
                return new ObterUsuarioServicoRespostaModel("Não existe usuário com email informado");

            var usuario = new UsuarioEntidade(usuarioDto);
            var resposta = new ObterUsuarioServicoRespostaModel(usuario);
            return resposta;
        }

        public async Task<ObterUsuarioServicoRespostaModel> ObterUsuario(int codigoUsuario)
        {
            var usuarioDto = await _usuarioRepositorio.ObterUsuario(codigoUsuario);

            if (usuarioDto == null)
                return new ObterUsuarioServicoRespostaModel("Não existe usuário com email informado");

            var usuario = new UsuarioEntidade(usuarioDto);
            var resposta = new ObterUsuarioServicoRespostaModel(usuario);
            return resposta;
        }

        private string CifrarSenhaUsuario(string senha)
        {
            var senhaCifrada = AES.Encrypt(senha, CHAVE_CIFRA);
            return senhaCifrada;
        }
    }

    public interface IUsuarioServico
    {
        Task<AtualizarUsuarioServicoRespostaModel> AtualizarUsuario(int codigoUsuario, AlterarUsuarioRequestModel novosDadosUsuario);
        Task<CadastrarUsuarioServicoRespostaModel> CadastrarUsuario(UsuarioEntidade usuario);
        Task<ObterUsuarioServicoRespostaModel> ObterUsuario(string emailUsuario);
        Task<ObterUsuarioServicoRespostaModel> ObterUsuario(int codigoUsuario);
        Task<AutenticarUsuarioRespostaModel> AutenticarUsuario(string emailUsuario, string senha, string perfilLogin);
    }
}
