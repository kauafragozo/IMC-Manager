using System.Data.Common;
using System.Reflection.PortableExecutable;
using IMCManager.Models;
using IMCManager.Services;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace IMCManager.UI
{

    public static class ImcUI
    {

        public static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("=== IMC Manager ===");
            Console.WriteLine("== Selecione uma Operação:  ==");
            Console.WriteLine("= 1. Cadastrar Paciente =");
            Console.WriteLine("= 2. Exibir Pacientes =");
            Console.WriteLine("= 3. Pesquisar Paciente =");
            Console.WriteLine("= 4. Editar Paciente =");
            Console.WriteLine("= 5. Excluir Paciente =");
            Console.WriteLine("= 6. Consultar Classificações =");
            Console.WriteLine("= 7. Calcular IMC =");
            Console.WriteLine("= 8. Sair =");
        }


        public static void ConsultarClassificações()
        {
            Console.Clear();
            Console.WriteLine("= Consulta de Classificações: =");
            Console.WriteLine("IMC menor que 18.5 = Abaixo do Peso ");
            Console.WriteLine("IMC maior ou igual que 18.5 && IMC menor que 25 = Peso Normal ");
            Console.WriteLine("IMC maior ou igual que 25 && IMC menor que 30 = Sobre Peso ");
            Console.WriteLine("IMC maior ou igual que 30 && IMC menor que 35 =  Obesidade Grau III");
            Console.WriteLine("IMC maior ou igual que 35 && IMC menor que 40 = Obesidade Grau II");
            Console.WriteLine("IMC maior que 40 = Obesidade Grau III");
            Console.WriteLine("= Pressione qualquer tecla para voltar! =");
            Console.ReadKey();
        }

        public static bool Sair()
        {
            Console.Clear();
            Console.WriteLine("Tem certeza que deseja sair? (s/n)");
            string confirmarSaida = Console.ReadLine();

            return confirmarSaida.ToLower() == "s";

        }

        public static void OpInválida()
        {
            Console.Clear();
            Console.WriteLine("Erro! Selecione uma Opção Válida!");
            Console.ReadKey();
        }

        public static (decimal peso, decimal altura) LerDadosCalculoIMC()
        {

            decimal peso;
            decimal altura;
            Console.WriteLine("Digite o Peso do Paciente: ");
            while (!decimal.TryParse(Console.ReadLine().Replace(".", ","), out peso))
            {
                Console.Clear();
                Console.WriteLine("Digite um valor válido!");
                Console.ReadKey();
            }

            Console.WriteLine("Digite a altura do Paciente: ");
            while (!decimal.TryParse(Console.ReadLine().Replace(".", ","), out altura))
            {
                Console.Clear();
                Console.WriteLine("Digite um valor válido! ");
                Console.ReadKey();

            }
            return (peso, altura);

        }

        public static (string nome, string objetivo, decimal peso, decimal altura) LerDadosCadastro()
        {

            Console.Clear();
            Console.WriteLine("=== CADASTRO DE PACIENTE ===");
            Console.WriteLine("Digite o nome do(a) Paciente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Selecione o objetivo do Paciente: ");
            string objetivo = ImcUI.AtribuirObjetivo();

            decimal peso;
            Console.WriteLine("Digite o Peso do(a) Paciente: ");
            while (!decimal.TryParse(Console.ReadLine().Replace(".", ","), out peso))
            {
                Console.Clear();
                Console.WriteLine("Digite um valor válido!");
                Console.ReadKey();
            }
            decimal altura; ;
            Console.WriteLine("Digite a altura do(a) Paciente: ");

            while (!decimal.TryParse(Console.ReadLine().Replace(".", ","), out altura))
            {
                Console.Clear();
                Console.WriteLine("Digite um valor válido! ");
                Console.ReadKey();
            }

            return (nome, objetivo, peso, altura);

        }

        public static string AtribuirObjetivo()
        {
            Console.WriteLine("= Objetivos =");
            Console.WriteLine("1 - Perder Peso");
            Console.WriteLine("2 - Manter Peso ");
            Console.WriteLine("3 - Ganhar Massa Muscular");
            Console.WriteLine("4 - Melhorar Condicionamento Fisico");
            string objetivo = Console.ReadLine();
            return objetivo;
        }
        public static string LerDadosBusca()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome ou inicial do nome do(a) Paciente que deseja buscar?");
            return Console.ReadLine();
        }

        public static int LerId()
        {
            Console.Clear();
            Console.WriteLine("Qual o ID do Paciente? ");
            int.TryParse(Console.ReadLine(), out int id);
            return id;

        }

        public static (string nome, string objetivo, decimal peso, decimal altura) LerDadosEdição()
        {
            decimal peso = 0;
            decimal altura = 0;
            Console.Clear();
            Console.WriteLine("== Edição de Paciente ==");
            Console.WriteLine("Qual o novo nome? (Deixe em branco para manter o mesmo)");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o objetivo do Paciente? (Deixe em branco para mater o mesmo)");
            string objetivo = AtribuirObjetivo();

            Console.WriteLine("Qual o Peso do paciente? (Deixe em branco para manter o mesmo)");
            while (!decimal.TryParse(Console.ReadLine().Replace(".", ","), out peso))
            {
                Console.Clear();
                Console.WriteLine("Digite um valor válido!");
                Console.ReadKey();
            }

            Console.WriteLine("Qual a altura do paciente?");
            while(!decimal.TryParse(Console.ReadLine().Replace(".",","), out altura))
            {
                Console.Clear();
                Console.WriteLine("Digite um valor válido!");
                Console.ReadKey();
            }
            
            return(nome,objetivo,peso,altura);
            
        }

        public static void ExibirSucesso()
        {
            Console.Clear();
            Console.WriteLine("Operação Efetuada com Sucesso!");
            Console.ReadKey();
        }

        public static void ExibirErro(string mensagem)
        {
            Console.Clear();
            Console.WriteLine($"Erro: {mensagem}");
            Console.ReadKey();
        }

        public static void MostrarLista(List<Paciente> pacientes)
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Pacientes ===");

            if (pacientes.Count <= 0) { Console.WriteLine("Nenhum registro encontrado "); }
            else
            {
                foreach (var p in pacientes)
                {
                    Console.WriteLine("--------------");
                    Console.WriteLine($"| ID: {p.PID} | Nome: {p.PNome} | Classificação: {p.PClasse} | Objetivo: {p.PObjetivo} | Peso: {p.PPeso} | Altura: {p.PAltura:F2} | IMC: {p.PImc} | Data Cadastro:{p.PCad}");
                    Console.WriteLine("--------------");
                }
            }
            Console.ReadKey();
        }
    }
}