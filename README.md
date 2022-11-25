## Projeto Final Turma QUA.315.024 SENAI Taguatinga - DF
<h1>Desenvolvedor <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/"  target="_blank" rel="noopener noreferrer">
  <img height="32" src="https://iconape.com/wp-content/files/sh/51404/png/c--4.png" alt="c#"/></a></h1>

## **Ferramentas**
<a  href="https://learn.microsoft.com/en-us/visualstudio/windows/?view=vs-2022" target="_blank" rel="noopener noreferrer">
    <img height="32" src="https://upload.wikimedia.org/wikipedia/commons/5/59/Visual_Studio_Icon_2019.svg" alt="VS"/></a>
<a  href="https://code.visualstudio.com/docs" target="_blank" rel="noopener noreferrer">
  <img height="32" src="https://upload.wikimedia.org/wikipedia/commons/9/9a/Visual_Studio_Code_1.35_icon.svg" alt="VSC"/></a>
<a  href="https://swagger.io/docs/" target="_blank" rel="noopener noreferrer">
    <img height="32" src="https://iconape.com/wp-content/files/kd/371533/svg/371533.svg" alt="Swagger"/></a>

## **Tecnologias**
<a href="https://learn.microsoft.com/pt-br/dotnet/csharp/"  target="_blank" rel="noopener noreferrer">
  <img height="32" src="https://iconape.com/wp-content/files/sh/51404/png/c--4.png" alt="c#"/></a>
<a href="https://learn.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver16"  target="_blank" rel="noopener noreferrer">
  <img height="32" src="https://cdn-icons-png.flaticon.com/512/5968/5968409.png" alt="MSSQL"/></a>
<a  href="https://developer.mozilla.org/pt-BR/docs/Web/CSS" target="_blank" rel="noopener noreferrer">
  <img height="32" src="https://iconape.com/wp-content/files/vt/353246/png/css-3-logo.png" alt="CSS"/></a>
<a  href="https://developer.mozilla.org/pt-BR/docs/Web/HTML" target="_blank" rel="noopener noreferrer">
  <img height="32" src="https://iconape.com/wp-content/files/qr/67382/png/html-5.png" alt="HTML"/></a>

## **Frameworks**
<a  href="https://learn.microsoft.com/pt-br/dotnet/" target="_blank" rel="noopener noreferrer">
  <img height="32" src="https://cdn.iconscout.com/icon/free/png-256/microsoft-dotnet-1175177.png" alt="dotnet"/></a>
<a  href="https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0" target="_blank" rel="noopener noreferrer">
  <img height="32" src="https://cdn.worldvectorlogo.com/logos/blazor.svg" alt="blazor"/></a>

<hr></hr>

## **Sistema Gerenciador de Frota Aerea**

O objetivo do sistema é gerenciar frotas aereas. Dispondo do cadastro de aeronaves, pilotos, controle de voos e controle de manutenções da frota.

**FrontEnd em desenvolvimento...tenha paciência**


Este repositório dispõe apenas da versão inicial da API, que pode ser testada seguindo a instruções abaixo.
<hr></hr>

## Como executar o projeto

**Clonar o repositório**
```
git clone https://github.com/And3rsLMM/VoeAirlines.git
```

**Executar a aplicação**

Executar o seguinte comando ou utilizar a ferramenta de Debug do Visual Studio ou Visual Studio Code (normalmente pressionando F5):
```
dotnet watch run (normalmente ira abrir a UI do Swagger automaticamente)
```

## Como testar a API

**Acessar a interface de teste do Swagger***
A UI do Swagger estará disponível na URL https://localhost:[porta]/swagger (a porta pode variar e deve ser observada no terminal ao executar o projeto).

**Consumir os endpoints**
Sugestão de ordem para testar a aplicação:

1) Criar, editar e excluir Aeronaves
2) Criar, editar e excluir Manutenção
3) Criar, editar e excluir Piloto
4) Criar, editar e excluir Voo
