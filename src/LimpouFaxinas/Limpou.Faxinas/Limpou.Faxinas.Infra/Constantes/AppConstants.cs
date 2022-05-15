using System;
using System.Collections.Generic;
using System.Text;

namespace Limpou.Faxinas.Infra.Constantes
{
    public static class AppConstants
    {
        #region INFRAESTRUTURA

        public const string CONNECTION_STRING = "server=us-cdbr-east-03.cleardb.com;user=bf9c7fe9712622;password=e459392c;database=heroku_3dc1bcc8f5cdd12;SSL Mode=None";

        public const string CHAVE_CIFRA = "1e64fdce-e561-4f3d-bb78-0d7c8c86d14b";

        #endregion

        #region USUARIO_SQL

        public const string SQL_OBTER_USUARIO_POR_EMAIL = @"SELECT 
	                                                        u.id_usuario AS Codigo,
                                                            u.email_usuario AS Email,
                                                            u.senha_usuario AS Senha,
                                                            u.nome_usuario AS Nome,
                                                            u.cpf_usuario AS Cpf,
                                                            u.telefone_usuario AS NumeroTelefone,
                                                            u.perfil_usuario AS Perfil,
                                                            e.id_endereco AS CodigoEndereco,
                                                            e.chave_endereco AS ChaveIdentificacaoEndereco,
                                                            e.cep_endereco AS CepEndereco,
                                                            e.logradouro_endereco AS LogradouroEndereco,
                                                            e.numero_endereco AS NumeroEndereco,
                                                            e.complemento_endereco AS ComplementoEndereco,
                                                            e.bairro_endereco AS BairroEndereco,
                                                            e.uf_endereco AS UfEndereco
                                                        FROM usuario u
                                                        INNER JOIN endereco e ON u.id_endereco = e.id_endereco
                                                        WHERE email_usuario = @email_usuario";

        public const string SQL_OBTER_USUARIO_POR_CODIGO = @"SELECT 
	                                                        u.id_usuario AS Codigo,
                                                            u.email_usuario AS Email,
                                                            u.senha_usuario AS Senha,
                                                            u.nome_usuario AS Nome,
                                                            u.cpf_usuario AS Cpf,
                                                            u.telefone_usuario AS NumeroTelefone,
                                                            u.perfil_usuario AS Perfil,
                                                            e.id_endereco AS CodigoEndereco,
                                                            e.chave_endereco AS ChaveIdentificacaoEndereco,
                                                            e.cep_endereco AS CepEndereco,
                                                            e.localidade_endereco AS LocalidadeEndereco,
                                                            e.logradouro_endereco AS LogradouroEndereco,
                                                            e.numero_endereco AS NumeroEndereco,
                                                            e.complemento_endereco AS ComplementoEndereco,
                                                            e.bairro_endereco AS BairroEndereco,
                                                            e.uf_endereco AS UfEndereco
                                                        FROM usuario u
                                                        INNER JOIN endereco e ON u.id_endereco = e.id_endereco
                                                        WHERE id_usuario = @id_usuario";

        public const string SQL_CADASTRAR_USUARIO = @"INSERT INTO `heroku_3dc1bcc8f5cdd12`.`usuario`
                                                    (`email_usuario`,
                                                    `senha_usuario`,
                                                    `nome_usuario`,
                                                    `cpf_usuario`,
                                                    `telefone_usuario`,
                                                    `perfil_usuario`,
                                                     `id_endereco`)
                                                    VALUES
                                                    (@email_usuario,
                                                    @senha_usuario,
                                                    @nome_usuario,
                                                    @cpf_usuario,
                                                    @telefone_usuario,
                                                    @perfil_usuario,
                                                    @id_endereco);";

        public const string SQL_ATUALIZAR_USUARIO = @"UPDATE 
	                                                    usuario
                                                    INNER JOIN endereco ON
	                                                    usuario.id_endereco = endereco.id_endereco
                                                    SET
                                                        usuario.email_usuario = @email_usuario,
                                                        usuario.senha_usuario = @senha_usuario,
                                                        usuario.nome_usuario = @nome_usuario,
                                                        usuario.cpf_usuario = @cpf_usuario,
                                                        usuario.telefone_usuario = @telefone_usuario,
                                                        endereco.bairro_endereco = @bairro_endereco,
                                                        endereco.cep_endereco = @cep_endereco,
                                                        endereco.complemento_endereco = @complemento_endereco,
                                                        endereco.logradouro_endereco = @logradouro_endereco,
                                                        endereco.numero_endereco = @numero_endereco,
                                                        endereco.uf_endereco = @uf_endereco,
                                                        endereco.localidade_endereco = @localidade_endereco
                                                  WHERE usuario.id_usuario = @id_usuario";

        #endregion

        #region ENDERECO_SQL

        public const string SQL_CADASTRAR_ENDERECO = @"INSERT INTO `heroku_3dc1bcc8f5cdd12`.`endereco`
                                                    (`chave_endereco`,
                                                    `cep_endereco`,
                                                    `logradouro_endereco`,
                                                    `numero_endereco`,
                                                    `complemento_endereco`,
                                                    `bairro_endereco`,
                                                    `uf_endereco`,
                                                    `localidade_endereco`)
                                                    VALUES
                                                    (@chave_endereco,
                                                    @cep_endereco,
                                                    @logradouro_endereco,
                                                    @numero_endereco,
                                                    @complemento_endereco,
                                                    @bairro_endereco,
                                                    @uf_endereco,
                                                    @localidade_endereco);";

        public const string SQL_OBTER_CODIGO_ENDERECO_POR_CHAVE = "SELECT id_endereco FROM `heroku_3dc1bcc8f5cdd12`.`endereco` WHERE chave_endereco = @chave_endereco";

        #endregion
    }
}
