# Teste .NET Marttech

## Entity Relationship Diagram
<img src="Teste .NET Marttech ERD.png" title="erd teste .net marttech">

## Regras do Teste .NET

O objetivo do teste é você mostrar que é capaz de construir uma API utilizando o .NET, sinta se livre para criar a aplicação como desejar, inclusive mudar um pouco o escopo para adicionar novas funcionalidades e recursos.
Caso não consiga desenvolver o teste por completo, faça o seu melhor e nos envie mesmo assim, para que possamos avaliar seu desempenho.

Problema:
A empresa “XYZ” deseja atender clientes por todo o Brasil, e para isso o CEO da empresa decidiu contratar um desenvolvedor para criar uma loja virtual e informou os seguintes requisitos:

Gerenciamento de Clientes:
Possibilidade de listar, criar, alterar e deletar Clientes
Um cliente precisa obrigatoriamente possuir: Nome, Data de nascimento, E-mail, Telefone e Endereço
Cada cliente pode possuir mais de um e-mail e telefone.
Um endereço possui: Logradouro [Obrigatório], Número [Obrigatório], Complemento [Opcional], Bairro [Obrigatório], CEP [Obrigatório] e UF [Obrigatório].
A exclusão de um cliente é independente. Caso um cliente seja excluído suas dependências devem obrigatoriamente serem excluídas também [Endereço, Telefones, E-mails, Usuário etc.]
Para que seja possível o gerenciamento de clientes o usuário precisa estar obrigatoriamente autenticado no sistema.

Gerenciamento de Usuários:
 Possibilidade de listar, criar, alterar e deletar Usuários
Um usuário precisa obrigatoriamente possuir: Login e Senha.
Um usuário precisa obrigatoriamente possuir um cadastro como cliente no sistema.
Para que seja possível o gerenciamento de usuários o usuário precisa estar obrigatoriamente autenticado no sistema.

Gerenciamento de Produtos:
Possibilidade de listar, criar, alterar e deletar Produtos
Um produto precisa obrigatoriamente possuir: Descrição, Foto e Preço Unitário. Necessário inserir pelo menos 10 produtos na base de dados [via migration].
Para que seja possível o gerenciamento de produtos o usuário precisa estar obrigatoriamente autenticado no sistema.

Carrinho de compras:
 Possibilidade adicionar, remover ou alterar a quantidade de itens no carrinho.
Um carrinho de compra precisa obrigatoriamente possuir: Itens, Identificador do cliente e Total Geral
Os itens do carrinho de compra precisam obrigatoriamente possuir: Identificador do produto, quantidade e Subtotal.
Autenticação de usuários:
É obrigatoriamente necessário possuir uma forma autenticação de usuários [de sua escolha].

Armazenamento de dados:
É obrigatoriamente necessário que os dados de usuários, clientes, produtos, carrinho de compras e itens do carrinho de compra estejam armazenados em um banco de dados [de sua escolha].

Critérios de aceite:
É obrigatoriamente necessário utilizar o Entity Framework para persistir e consultar os dados no banco de dados.
É obrigatoriamente necessário possuir um controle de versionamento de banco de dados [migration].
É obrigatoriamente necessário desenvolver utilizando a tecnologia .NET Core 5 ou 6
É obrigatoriamente necessário criar um repositório no GitHub para a aplicação.
Diferenciais [opcional]:
Criar um Front-End para visualização e gerenciamento da loja virtual [Linguagem e requisitos de sua preferência].
Utilizar o padrão RESTful API.
Utilizar como forma de autenticação OAuth2 ou Bearer Token.
Desenvolver testes unitários.
Criação de uma documentação para visualização dos endpoints disponíveis na aplicação [Swagger].
Boas práticas de versionamento Git.

