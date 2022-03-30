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
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
