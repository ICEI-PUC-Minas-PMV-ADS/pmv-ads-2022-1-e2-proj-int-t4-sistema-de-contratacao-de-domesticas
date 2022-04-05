# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

|Caso de Teste |CT-01 – Cadastro do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve exibir na tela principal as opções de cadastro e login e alteração de senha. RF-002- O sistema deve conter uma opção que permita o usuário criar uma nova senha em caso de esquecimento, RF-003- O usuário deve informar nas telas de cadastro e login se será prestadora ou contratante  |
|**Entrada** | Cadastro: Após preencher o email, senha, telefone e endereço. Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login e cadastro. Permitir o cadastro do usuário que deseja prestar serviços ou contratar serviços doméstico.  |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar no botão Cadastre-se  4) Preencher os campos com informações validas 5) Clicar no botão Cadastrar. |
|**Critérios de Êxito** | "Cadastro completo, seja bem vindo". |

|Caso de Teste |CT-02 – Login do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve exibir na tela principal as opções de cadastro e login e alteração de senha. |
|**Entrada** | Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar na opção central de loguin  4) Preencher os campos com informações validas 5) Clicar no botão Logar. |
|**Critérios de Êxito** | O usuário será direcionado a homepage e poderá escolher o serviço desejado. |

|Caso de Teste |CT-03 – Esqueceu Senha  |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** |RF-002- O sistema deve conter uma opção que permita o usuário criar uma nova senha em caso de esquecimento
|**Entrada** | Após clicar no botão "ESQUECEU A SENHA", o usuário deverá informar o email cadastrado. |
|**Objetivo do Teste** | Verificar se os campos do formulário estão sendo exibidos corretamente.  |
|**Passos** |1) Acessar o Navegador  2) Informar o endereço do Site  3) Visualizar a página de login  4)Esqueceu a senha 5) Informar o email, onde será enviado um link para a nova senha) Insira uma nova senha no campo [senha] e no campo [confirme sua senha] redigite a senha e clique no botão próximo que levará para a próxima tela |
|**Critérios de Êxito** | Senha alterada com sucesso. |

|Caso de Teste |CT-04 – Solicitação de Serviço |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-004-  O usuário contratante informe a região que está situada e quais serviços irá precisar |
