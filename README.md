# TodoAPI

## Pré-requistos para Rodar o Projeto
**<p>.NET RUN TIME - 6.0</p>**

***

## Serialização e Desserialização
<p>Se você é novo usando ASPNET, saiba que ele pega o JSON enviado e transforma/serializa AUTOMATICAMENTE em c# para nós, no TIPO que esperamos receber, e ao enviar/retornar algum dado para alguém, ele também desserializa automaticamente e entregará os dados no formato JSON, vale lembrar que ele irá fazer isso com base no conjunto de propriedades que definem a classe, e também com base no nome dessas mesmas propriedades.</p>

***

## Como baixar e rodar o projeto
1. Baixe ou Execute um `git clone` do projeto.
2. Vá até a pasta do projeto via CLI(Terminal)
3. Execute um `dotnet restore`
4. Execute um `dotnet build`
5. Execute um `dotnet ef update` para subir a migration e criar o database e as tabelas.

**OBS:Você não precisa ter o DATABASE já CRIADO ou mesmo as TABELAS, a MIGRATION já fará isso para você, MESMO QUE O DATABASE não exista, nesse caso estou utilizando um banco SQLITE**

6. Execute um `dotnet run`
7. Agora basta apenas que você use o PostMan para utilizar a API por completo, ou parcialmente através do navegador.
