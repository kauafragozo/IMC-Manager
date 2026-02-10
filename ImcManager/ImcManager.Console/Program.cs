using System;
using System.Data;
using ImcProgram.Entities;
using ImcProgram.Service;
using ImcProgram.Utls;
using ImcProgram.Context;
using Dapper;
using Microsoft.Data.SqlClient;
using ImcProgram.Repository;

namespace ImcProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utils utils = new Utils();
            Paciente paciente = new Paciente();
            DataContextEF context = new DataContextEF();
            PacientesRepository repo = new PacientesRepository(context);
            PacienteService service = new PacienteService(repo);


            Console.WriteLine("=== IMC Manager ===");
            Console.WriteLine("== Seja bem-vindo(a)! ==");

            Console.WriteLine("Aperte qualquer tecla para continuar!");
            Console.ReadKey();

            bool executando = true;
            while (executando == true)
            {

                utils.ExibirMenu();
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                    
                        break;
                    case 2:
                        Console.WriteLine("= 2 =");
                        break;
                    case 3:
                        Console.WriteLine("= 3 =");
                        break;
                    case 4:
                        Console.WriteLine("= 4 =");
                        break;
                    case 5:
                        Console.WriteLine("= 5 =");
                        break;
                    case 6:
                        utils.ConsultarClassificações();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Insira o Peso do Paciente: ");
                        string inputpeso = Console.ReadLine().Replace(',', ('.'));
                        if (!double.TryParse(
                            inputpeso,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture,
                            out double peso))
                        {
                            Console.WriteLine("Peso Inválido! ");
                            Console.ReadKey();
                        }
                        paciente.PaPeso = peso;

                        Console.WriteLine("Insira a Altura do Paciente: ");
                        string inputaltura = Console.ReadLine().Replace(',', '.');

                        if (!double.TryParse(
                            inputaltura,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture,
                            out double altura))
                        {
                            Console.WriteLine("Peso Inválido! ");
                            Console.ReadKey();
                        }
                        paciente.PaAltura = altura;

                        // // // // double imc = pacienteService.CalcularImc();
                        Console.Clear();
                        Console.WriteLine($"O Peso é: {paciente.PaPeso}");
                        Console.WriteLine($"A Altura é: {altura}");
                        //Console.WriteLine($"O IMC é: {imc} ");
                        Console.WriteLine("= Pressione qualquer tecla para continuar =");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Tem certeza que deseja sair do sistema? ( s/n)");
                        string resp = Console.ReadLine();
                        if (resp == "n" || resp == "N")
                        {
                            executando = true;
                        }
                        else if (resp == "s" || resp == "S")
                        {
                            Console.Clear();
                            executando = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("= Erro! Opção Inválida =");
                            Console.ReadKey();
                            executando = true;
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("= Erro: Opção Inválida! =");
                        Console.ReadKey();
                        break;
                }

            }



        }
    }
}