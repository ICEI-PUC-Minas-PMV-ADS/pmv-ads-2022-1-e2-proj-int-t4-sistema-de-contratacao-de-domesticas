# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

|Caso de Teste |CT-01 – Cadastro do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve exibir na tela principal as opções de cadastro e login e alteração de senha. RF-002- O sistema deve conter uma opção que permita o usuário criar uma nova senha em caso de esquecimento, RF-003- O usuário deve informar nas telas de cadastro e login se será prestadora ou contratante.  |
|**Entrada** | Cadastro: Após preencher o email, senha, telefone e endereço. Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login e cadastro. Permitir o cadastro do usuário que deseja prestar serviços ou contratar serviços doméstico.  |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar no botão Cadastre-se  4) Preencher os campos com informações validas 5) Clicar no botão Cadastrar. |
|**Critérios de Êxito** | "Cadastro completo, seja bem vindo". |

|Caso de Teste |CT-02 – Login do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve exibir na tela principal as opções de cadastro e login  |
|**Entrada** | Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar na opção central de loguin  4) Preencher os campos com informações validas 5) Clicar no botão Logar. |
|**Critérios de Êxito** | O usuário será direcionado a homepage e poderá escolher o serviço desejado. |



|Caso de Teste |CT-03 – Solicitação de Serviço |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-004-  O usuário contratante informe a região que está situada e quais serviços irá precisar.RF-005- O sistema deverá permitir que o contratante filtre as buscas por localização. |
**Entrada** | Atraves de um formulário contendo tipos de serviço, região solicitada.|
|**Objetivo do Teste** | Permitir ao usuário a opção de solicitar serviço, especificando se será limpeza simples ou faxina e região desejada. |
|**Passos** | 1) Acessar o navegador 2) Acessar a plataforma 3) Realizar o login 4) Escolher a opção desejada (solicitar limpeza simples ou faxina) 5) Definir região 7)Confirmar opção desejada 7) Confirmar dia/horário e região desejada.   |
|**Critérios de Êxito** | "Solicitação concluída". Visualizar se sua solicitação consta em aberto e selecione o prestador de serviço desejado. |


|Caso de Teste |CT-04 –  Feedbacks dos usuários |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-006 - O sistema deve disponibilizar campo para fornecimento de feedback dos usuários, tanto do contratante como do prestador ao final do serviço prestado. |
|**Entrada** |  Através do email fornecido na tela de duvidas. |
|**Objetivo do Teste** | Permitir que o usuário retorne sobre os problemas encontrados no sistema. 
|**Passos** | 1) Acessar a plataforma 2) Fazer o login 3) Escolher serviço realizado 4) Realizar comentário e/ou avaliação.  |
|**Critérios de Êxito** | " Comentário Concluído.". Verificar o comentário feito em relação ao serviço ofertado. 

|Caso de Teste |CT-05 –  Suporte ao usuário. |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-007 - O sistema deve fornecer informações de contato para que os usuários possam receber suporte e/ou tirar dúvidas. |
|**Entrada** |  Através de um formulário contendo nome, email e campo para digitação da dúvida em questão, onde a equipe poderá responder às dúvidas do usuário. 
|**Objetivo do Teste** | Permitir ao usuário tire as dúvidas sobre o sistema Limpou.  |
|**Passos** | 1) Acessar a plataforma 2) Fazer o login 3) Acessar o campo "dúvidas" 4) Ler o informativo 5) Enviar 6)Aguardar o retorno da equipe.  |
|**Critérios de Êxito** | " Sua dúvida foi enviada, aguarde o retorno de nossa equipe.". Verificar a duvida enviada pelo usuário.



|Caso de Teste |CT-06 –  Sobre Nós. |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-010 - A aplicação deverá permitir ao usuário visualizar informações sobre a função principal do sistema na tela inicial.|
|**Entrada** |  Através de um texto informativo sobre o sistema (Limpou), onde o usuário poderá entender melhor sobre o objetivo e função principal do site. 
|**Objetivo do Teste** | Permitir que o usuário conheça a principal função do sistema.  |
|**Passos** | 1) Acessar a plataforma 2) Ir para Página inicial 3) Rolar para campo " Sobre nós" e acessar o texto  |




