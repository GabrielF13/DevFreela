# DevFreela

## Sobre o Projeto
O **DevFreela** é uma plataforma de freelancing desenvolvida para conectar clientes e desenvolvedores, facilitando a criação, gerenciamento e entrega de projetos. A aplicação permite a interação direta entre contratantes e freelancers, proporcionando um ambiente seguro e eficiente para ambos os lados.

## Funcionalidades
- Cadastro de usuários:
  - Registro e login de clientes e freelancers.
  - Atualização de perfis.
- Gerenciamento de projetos:
  - Criação, edição e exclusão de projetos.
  - Listagem e pesquisa de projetos.
  - Contratação de freelancers para projetos.
- Interação entre usuários:
  - Envio de mensagens entre clientes e freelancers.
  - Avaliação de projetos e freelancers.
- Administração financeira:
  - Controle de pagamentos.
  - Histórico de transações.

## Tecnologias Utilizadas
- **C#**
- **ASP.NET Core**
- **Entity Framework Core**
- **SQL Server**
- **RabbitMQ** (mensageria)
- **Docker**

## Estrutura do Projeto
O projeto segue o padrão Clean Architecture com as seguintes camadas:

- **Application**: Contém casos de uso e regras de negócio.
- **Domain**: Contém as entidades e interfaces.
- **Infrastructure**: Implementação de repositórios e integrações externas.
- **WebAPI**: Responsável por expor os endpoints.

## Requisitos
- .NET 6.0 ou superior
- SQL Server
- Docker (opcional)

## Como Executar o Projeto
1. Clone o repositório:
   ```bash
   git clone https://github.com/GabrielF13/DevFreela.git
   ```
2. Navegue até a pasta do projeto:
   ```bash
   cd DevFreela
   ```
3. Configure a string de conexão para o banco de dados no arquivo `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=SEU_SERVIDOR;Database=DevFreelaDb;User Id=SEU_USUARIO;Password=SUA_SENHA;"
   }
   ```
4. Execute as migrations para criar o banco de dados:
   ```bash
   dotnet ef database update
   ```
5. Inicie a aplicação:
   ```bash
   dotnet run
   ```
6. Acesse a API através do navegador ou de ferramentas como Postman no endpoint:
   ```
   http://localhost:5000
   ```

## Docker (opcional)
Se desejar executar o projeto utilizando Docker:
1. Construa a imagem Docker:
   ```bash
   docker build -t devfreela .
   ```
2. Execute o container:
   ```bash
   docker run -p 5000:5000 devfreela
   ```

## Contribuição
Contribuições são bem-vindas! Siga os passos abaixo para contribuir:
1. Fork este repositório.
2. Crie uma branch com sua feature:
   ```bash
   git checkout -b minha-feature
   ```
3. Commit suas alterações:
   ```bash
   git commit -m "Adicionei uma nova funcionalidade"
   ```
4. Envie para o repositório remoto:
   ```bash
   git push origin minha-feature
   ```
5. Abra um Pull Request.

## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---
Feito com ❤ por [GabrielF13](https://github.com/GabrielF13)

