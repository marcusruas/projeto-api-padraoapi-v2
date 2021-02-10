# PadraoAPI
_Scaffold criado para definir o padrão de desenvolvimento de minhas APIS_

### Sobre o projeto
Api criada com o framework .NET Core na versão 3.1, utilizando pacotes criados com arquitetura .NET Core 2.1. 

### Configurações da API
Com o intuito de facilitar o fork do repositório de Scaffold, as configurações da API (middlewares básicos, serviços e implementação de pacotes etc.) foram colocadas em pacotes Nuget localizados no repositório abaixo:

*https://github.com/marcusruas/MandradePkgs*

Até a data da implementação desta documentação (14/01/2021), os pacotes ainda não foram disponibilizados em domínio público, sendo necessário a instalação dos pacotes localmente.

## Configurações iniciais necessárias
Para começar a desenvolver neste Scaffold, é necessário somente algumas coisas:
- Alterar o nome da solution principal (PadraoAPI.sln) para o nome da futura api;
- Alterar a parte onde diz "PadraoAPI" na classe de Startup da api para o nome da api desejada, bem como o nome do documento na invocação do serviço;
- Adicionar um arquivo de conexoes.json válido na camada de comunicação.

### Sufixos - Resumo
    * Representações de objetos
        * Regras de negócio do objeto - Dm
        * Representação do objeto no banco de dados (objeto de persistência) - Dpo (Data Persistence Object)
        * Representação do objeto para entrada/saida de dados da Api - Dto (Data Transfer Object)
        * Objetos de Valor - N/A (Motivo: objeto de valor não necesitam de abstrações)

    * Serviços
        * Camada de Serviço - Sv
        * Camada de Repositorio - Rp
        * Camada de Comunicacao - Cm
        * Camada de Api - Controller

### Ideias a serem implementadas
    * Utilizar Fluent Assertions no Dominio;
    * Padrão de retorno de queries para DML;
    * Padrão de segurança, tabelas.