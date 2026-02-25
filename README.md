<h1 > 📊 IMC Manager </h1>
Sistema de gerenciamento de pacientes com cálculo de IMC (Índice de Massa Corporal), desenvolvido em C# (.NET) utilizando Entity Framework Core e SQL Server.

<h2 > 🛠️ Tecnologias Ultilizadas  </h2>

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-14.0-239120?logo=c-sharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?logo=microsoftsqlserver&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-512BD4)
![Status](https://img.shields.io/badge/status-active-success)


---

<h2> 🚀 Funcionalidades  </h2>

✅ CRUD completo com funcionalidades de Cadastrar, Listar, Buscar, Editar e Excluir Paciente

📚 Consultar tabela de classificações IMC

🧮 Calcular IMC manualmente

📈 Exportar dados do Banco para um arquivo CSV, com uma pasta sendo criada dinamicamente na raiz do projeto para armazenar os arquivos

🚪 Sair do sistema

---

<h2> 🏗️ Arquitetura do Projeto </h2>

<h4> Models </h4>
Contém a entidade Paciente, que representa a estrutura da tabela no banco.


<h4> Services </h4> 
Camada responsável pelas regras de negócio, sendo divida em:
1. PacientesServices: Reponsavel pelas regras de negocio envolvendo a entidade Paciente;
2. ExportService: Metodos reposaveis pela expotação em CSV dos dados.

<h4> Data </h4>
Utiliza Entity Framework Core com SQL Server. 

🔌 String de Conexão armazenada no appSetting.JSON

A tabela é mapeada como: "TPACIENTES"

<h4> UI </h4> 
Responsável pela interação com o usuario via console:

<h2> 🗄️ Banco de Dados </h2> 


<h4> Importante: </h4>
Existe um script SQL na pasta Data do projeto.
Antes de executar a aplicação:

1. Abra o SQL Server Management Studio (SSMS)

2. Execute o script SQL localizado em: /Data/Script.sql
   
Isso criará:

1. Banco IMCMANAGERDB
2. TABELA T PACIENTES


<h2> ▶️ Como Executar  </h2>

1. Clone o repositório

2. Execute o script SQL da pasta Data

3. Configure a string de conexão se necessário

4. Rode o projeto com: dotnet run


<h2> 📌 Observações Técnicas </h2>

Validações impedem peso e altura menores ou iguais a zero

Busca por nome utiliza .Contains()

Classificação de IMC é automática

Atualização recalcula IMC automaticamente

Uso de decimal para maior precisão nos cálculos


<h2> 🎯 Objetivo do Projeto </h2>

Projeto desenvolvido com foco em:

Praticar arquitetura em camadas

Aplicar Entity Framework Core

Trabalhar CRUD completo

Aplicar regras de negócio

Melhorar organização de código

Simular um sistema real de gestão


<h2 align="center"> 🙋‍♂️Desenvolvido e testado por Kauã Fragozo, estudande de ADS e programador back-end  </h2>
