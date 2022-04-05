# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Definição do diagrama de personas:

![Patrícia dos Anjos](img/patricia.png)           
|Patrícia dos Anjos                                | Aplicativos     |
|--------------------------------------------------|-----------------|
|Idade: 38                                         |Linkedin         |
|Ocupação: Gerente de vendas hospitalares.         |Instagram        |

![Amanda Baião](img/amanda.png)
|Amanda Baião                                      | Aplicativos     |
|--------------------------------------------------|-----------------|
|Idade: 20                                         |Facebook         |
|Ocupação: Estudante de Antropologia               |GetNinjas        |

![Luiza Aragão](img/luiza.png) 
|Luiza Aragão                                      | Aplicativos     |
|--------------------------------------------------|-----------------|
|Idade: 30                                         |Facebook         |
|Ocupação: Gerente Financeira de Banco Digital     |Bancos Digitais  |

![Adolfo Luís](img/adolfo.png) 
|Adolfo Luís                                       | Aplicativos     |
|--------------------------------------------------|-----------------|
|Idade: 31                                         |Facebook         |
|Ocupação: Cozinheiro                              |Instagram        |



## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Adolfo Luís   | Ganhar renda extra atuando particularmente em domicílios.            | Ter condições financeiras para criação do filho.               |
|Patrícia dos Anjos        | Limpeza da casa em períodos de 4(quatro) em 4(quatro) dias.                  | Devido à alta demanda de tempo para o trabalho ela não consegue fazer manutenção da casa onde reside.  |
|Amanda Baião |Local para ganhar uma renda extra e para criação de uma poupança. |Ela busca trabalhos paralelos ao estágio para conseguir juntar dinheiro para pagar as provas de proficiência e auxílio de estadia no exterior|
|Luiza Aragão |Auxílio nas atividades de cozinha, limpeza, e pequenos cuidados do lar. |Precisa de auxílio regular em seu lar, como está atuando em home office não encontra tempo para pequenas tarefas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve exibir na tela principal as opções de cadastro e login  | ALTA | 
|RF-002| O usuário deve informar nas telas de cadastro e login se será prestadora ou contratante   | MÉDIA |
|RF-003| O usuário contratante informe a região que está situada e quais serviços irá precisar    | MÉDIA |
|RF-004| O sistema deverá permitir que o contratante filtre as buscas por localização   | MÉDIA |
|RF-005| O usuário prestador de serviço deve informar o valor diário do seu trabalho e quais serviços ela fornece    | MÉDIA |
|RF-006| O sistema deve solicitar um feedback dos usuários, tanto do contratante como do prestador, ao final do serviço prestado   | MÉDIA |
|RF-007| O sistema deve fornecer informações de contato para que os usuários possam receber suporte e/ou tirar dúvidas   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve armazenados e gerenciados em um banco de dados padrão SQL | ALTA |
|RNF-002| O sistema deve ser responsivo, permitindo a visualização adequada em um aparelho menor  | MÉDIA | 
|RNF-003| O sistema deve ser compatível com os principais navegadores do mercado  |  MÉDIA | 
|RNF-004| O sistema deve realizar consultas e pesquisas dos usuários em no máximo 10s | BAIXA |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 13/06/2022.  |
|02| A equipe não pode subcontratar o desenvolvimento do trabalho.         |
|03| A página inicial deve permitir o cadastro, login e alteração de senha. |
|04| O termo de responsabilidade aceito no cadastro isenta de quaisquer ocorrências resultantes de atendimentos e comunicação entre os usuários |
|05| A localização geográfica deverá ser restrita a usuários dentro do Brasil. |
|06| O sistema deverá ser implementado em linguagem C#, .NET, Javascript, HTML5 e CSS3. |
|07| Os usuários não poderão ter acesso aos dados pessoais de outros usuários. |
|08| A aplicação deve permitir realizar cadastro de serviços. |


## Diagrama de Casos de Uso

![Diagrama de Casos de Uso](img/DCASOSDEUSO.png)
