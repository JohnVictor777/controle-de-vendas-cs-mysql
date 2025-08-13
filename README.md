# Sistema de Controle de Vendas
### Aplicação Desktop em C# com Windows Forms e MySQL

Este projeto é um sistema de gerenciamento de vendas desenvolvido em C# com a tecnologia Windows Forms para a interface do usuário e um banco de dados MySQL para a persistência dos dados. O software foi projetado para ser uma solução de controle de vendas completa, com funcionalidades de cadastro e gestão para diversas entidades de negócio.

## Status do Projeto
O projeto está em fase de desenvolvimento, com as principais funcionalidades de CRUD e fluxo de vendas já implementadas.

## Funcionalidades Principais
O sistema oferece as seguintes telas e funcionalidades:

- **Controle de Clientes (`FrmCliente.cs`)**: Uma tela completa para realizar o C.R.U.D. (Criar, Ler, Atualizar, Deletar) de clientes. Inclui campos para informações pessoais e de contato, além de uma funcionalidade de busca de CEP que utiliza uma API externa para preenchimento automático.
- **Gestão de Funcionários (`FrmFuncionario.cs`)**: Tela para o C.R.U.D. de funcionários, com controle de senha, cargo e nível de acesso.
- **Gestão de Fornecedores (`FrmFornecedor.cs`)**: Tela dedicada ao C.R.U.D. de fornecedores, com campos específicos como CNPJ.
- **Gerenciamento de Produtos (`FrmProduto.cs`)**: Permite o C.R.U.D. de produtos, com controle de descrição, preço, quantidade em estoque e a associação a um fornecedor.
- **Processo de Vendas (`FrmVendas.cs`)**: A tela principal de vendas permite a busca de clientes e produtos, a adição de itens a um carrinho de compras e o cálculo do total da venda.
- **Tela de Pagamentos (`FrmPagamentos.cs`)**: Interface integrada à tela de vendas para processar o pagamento, calcular troco e finalizar a transação, registrando a venda e seus itens no banco de dados.

## Arquitetura e Tecnologias
O projeto segue uma arquitetura modular, com a lógica separada em camadas distintas para garantir a organização e a manutenibilidade do código.

- **`br.com.projeto.Model`**: Contém as classes que representam as entidades de negócio (e.g., `Cliente`, `Produto`, `Venda`), que são a base de dados do sistema.
- **`br.com.projeto.Dao`**: Camada de Acesso a Dados (DAO). Aqui estão as classes (`ClienteDAO.cs`, `ProdutoDAO.cs`, etc.) responsáveis por toda a comunicação com o banco de dados, utilizando comandos SQL para executar as operações de CRUD.
- **`br.com.projeto.View`**: Camada da interface do usuário. Contém todos os formulários (`Frm...cs`) desenvolvidos com Windows Forms.
- **`br.com.projeto.Conexao`**: Classe `ConnectionFactory.cs`, que centraliza e gerencia a conexão com o banco de dados MySQL, garantindo que as conexões sejam abertas e fechadas de forma segura.

### Tecnologias Utilizadas
- **Linguagem de Programação**: C#
- **Interface Gráfica**: Windows Forms
- **Banco de Dados**: MySQL
- **ORM**: Não utilizado (os comandos SQL são construídos diretamente nas classes DAO).

## Pré-requisitos
Para executar este projeto em sua máquina local, você precisará ter:
- Visual Studio (versão 2019 ou superior)
- .NET Framework 4.7.2
- MySQL Server
- MySQL Connector/NET

## Configuração do Banco de Dados
O projeto utiliza um banco de dados MySQL chamado `bdvendas`. Você pode fazer o download do script SQL para criação do banco e das tabelas através do link abaixo:

[**Download do Script SQL**](https://drive.google.com/file/d/1D43vHnK7C5bxvZw6VLhhhvwH7KI90gH6/view?usp=sharing)

Após o download, execute o script no seu ambiente MySQL para configurar o banco de dados.

## Como Executar o Projeto
1. Clone este repositório para sua máquina local.
2. Abra a solução `Controle de Vendas.sln` no Visual Studio.
3. Certifique-se de que o MySQL Connector/NET está instalado e referenciado no projeto.
4. Ajuste a string de conexão no arquivo `App.config`, se necessário.
5. Compile a solução e execute o projeto.

## Contribuição
Sinta-se à vontade para abrir issues ou pull requests se encontrar bugs, tiver sugestões de melhoria ou quiser adicionar novas funcionalidades.
