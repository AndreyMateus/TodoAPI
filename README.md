# TodoAPI

## Pré-requistos para Rodar o Projeto
**<p>.NET RUN TIME - 6.0</p>**
***
## Como baixar e rodar o projeto
1. Baixe ou Execute um `git clone` do projeto.
2. Vá até a pasta do projeto via CLI(Terminal)
3. Execute um `dotnet restore`
4. Execute um `dotnet build`
5. Execute um `dotnet ef update` para subir a migration e criar o database e as tabelas.

**OBS:Você não precisa ter o DATABASE já CRIADO ou mesmo as TABELAS, a MIGRATION já fará isso para você, MESMO QUE O DATABASE não exista, é necessário apenas que você tenha uma CONNECTION STRING para o seu SERVIDOR SQLSERVER, e nessa string de conexão você colocará o nome do DATABASE que será CRIADO(você pode escolher), também coloquei um SCRIPT EM C# que populará as TABELAS para você, mas só funciona uma vez após a execução, se quiser novos dados, adiciona manualmente.**

6. Execute um `dotnet run`
7. Agora basta apenas que você use o PostMan para utilizar a API por completo, ou parcialmente através do navegador.
