# 📊 IMC Manager 📊

Sistema de gerenciamento de pacientes com cálculo de IMC (Índice de Massa Corporal), desenvolvido em C# (.NET) utilizando Entity Framework Core e SQL Server.

---

🚀 Funcionalidades 🚀

✅ Cadastrar paciente

📋 Listar todos os pacientes

🔎 Buscar paciente por nome

✏️ Editar paciente

❌ Excluir paciente

📚 Consultar tabela de classificações IMC

🧮 Calcular IMC manualmente

🚪 Sair do sistema

---

## 🏗️ Arquitetura do Projeto


### 🗃️ Models 🗃️

Contém a entidade Paciente, que representa a estrutura da tabela no banco.

Campos principais:

PID (int) — ID do paciente

PNome (string) — Nome

PClasse (string) — Classificação do IMC

PObjetivo (string) — Objetivo físico

PPeso (decimal) — Peso

PAltura (decimal) — Altura

PImc (decimal) — IMC calculado

PCad (DateTime) — Data de cadastro


### 🗃️ Services 🗃️

Camada responsável pelas regras de negócio:

Cálculo de IMC

Classificação automática

Validações

CRUD com Entity Framework

Principais métodos:

CalcularImc()
ClassificarImc()
Cadastrar()
Atualizar()
Excluir()
ListarTodos()
BuscarNome()

### 🗃️ Data 🗃️


Utiliza Entity Framework Core com SQL Server.

🔌 String de Conexão
Server=localhost\SQLEXPRESS;
Database=IMCMANAGERDB;
TrustServerCertificate=true;
Trusted_Connection=true;

A tabela é mapeada como: "TPACIENTES"


### 🗃️ UI 🗃️

Responsável pela interação via console:

Menu principal

Leitura de dados

Validações

Exibição formatada

Tratamento de erros

---

🗄️ Banco de Dados

⚠️ Importante:
Existe um script SQL na pasta Data do projeto.

Antes de executar a aplicação:

Abra o SQL Server Management Studio (SSMS)

Execute o script SQL localizado em:

/Data/Script.sql 

Isso criará:

1. Banco IMCMANAGERDB
2. TABELA T PACIENTES
​
---

## ▶️ Como Executar ▶️

Clone o repositório

Execute o script SQL da pasta Data

Configure a string de conexão se necessário

Rode o projeto com: dotnet run

---

## 📌 Observações Técnicas 📌

Validações impedem peso e altura menores ou iguais a zero

Busca por nome utiliza .Contains()

Classificação de IMC é automática

Atualização recalcula IMC automaticamente

Uso de decimal para maior precisão nos cálculos

---

🎯 Objetivo do Projeto

Projeto desenvolvido com foco em:

Praticar arquitetura em camadas

Aplicar Entity Framework Core

Trabalhar CRUD completo

Aplicar regras de negócio

Melhorar organização de código

Simular um sistema real de gestão

---

## 🙋‍♂️Desenvolvido e testado por Kauã Fragozo, estudande de ADS e programador back-end 🙋‍♂️
