# Home Finances

Projeto de desafio técnico para desenvolvedor Fullstack.
**OBS**: a documentação estará em português para facilitar a avaliação

## Como executar o projeto

Recomenda-se utilizar o docker para executar uma instância do banco de dados. A seguir, comandos para auxiliar a instalação do docker em ambiente linux:
```bash
curl -fsSL https://get.docker.com -o get-docker.sh
sudo sh ./get-docker.sh --dry-run
```

Também é necessário utilizar o entity framework cli para execução das migrações.
```bash
dotnet tool install --global dotnet-ef
```

A seguir, comandos para execução do projeto:
```bash
# Executar container docker do PostgreSQL
docker run -p 5432:5432 -e POSTGRES_PASSWORD=1234 --name postgres -d postgres:18.1

# Executar as migrations para inicializar o banco
dotnet ef database update --project HomeFinances.WebApi/HomeFinances.WebApi.Infrastructure

# Executar a WebApi
dotnet watch --project HomeFinances.WebApi/HomeFinances.WebApi.Infrastructure

# Para o frontend é necessário antes criar um arquivo .env, dentro da pasta frontend, com a seguinte linha:
VITE_API_URL=http://localhost:5000

# Depois abra outra janela do terminal e execute o projeto
cd ./frontend/
npm i
npm run dev
```


## Sobre o projeto

- Desenvolvido com .NET 10
- Entity Framework
- Clean Architecture, separado nas camadas:
    - Domain
    - Application
    - API
    - Infrastructure
- Domain Driven Design (DDD): centralizando as regras de negócio na camada Domain, priorizando domínios ricos


## Funcionalidades

**Cadastro de pessoas:**

Deverá ser implementado um cadastro contendo as funcionalidades básicas de gerenciamento: criação, deleção e listagem.

Em casos que se delete uma pessoa, todas a transações dessa pessoa deverão ser apagadas.

O cadastro de pessoa deverá conter:
- Identificador (deve ser um valor único gerado automaticamente);
- Nome (texto);
- Idade (número inteiro positivo);


**Cadastro de categorias:**

Deverá ser implementado um cadastro contendo as funcionalidades básicas de gerenciamento: criação e listagem.

O cadastro de categoria deverá conter:
- Identificador (deve ser um valor único gerado automaticamente);
- Descrição (texto);
- Finalidade (despesa/receita/ambas)


**Cadastro de transações:**

Deverá ser implementado um cadastro contendo as funcionalidades básicas de gerenciamento: criação e listagem.

Caso o usuário informe um menor de idade (menor de 18), apenas despesas deverão ser aceitas.

O cadastro de transação deverá conter:
- Identificador (deve ser um valor único gerado automaticamente);
- Descrição (texto);
- Valor (número decimal positivo);
- Tipo (despesa/receita);
- Categoria: restringir a utilização de categorias conforme o valor definido no campo finalidade. Ex.: se o tipo da transação é despesa, não poderá utilizar uma categoria que tenha a finalidade receita.
- Pessoa (identificador da pessoa do cadastro anterior);


**Consulta de totais por pessoa:**

Deverá listar todas as pessoas cadastradas, exibindo o total de receitas, despesas e o saldo (receita – despesa) de cada uma.

Ao final da listagem anterior, deverá exibir o total geral de todas as pessoas incluindo o total de receitas, total de despesas e o saldo líquido.


**Consulta de totais por categoria (opcional):**

Deverá listar todas as categorias cadastradas, exibindo o total de receitas, despesas e o saldo (receita – despesa) de cada uma.

Ao final da listagem anterior, deverá exibir o total geral de todas as categorias incluindo o total de receitas, total de despesas e o saldo líquido.