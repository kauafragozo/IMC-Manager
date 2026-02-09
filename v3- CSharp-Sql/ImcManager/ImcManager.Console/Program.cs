using System;
using System.Data;
using ImcProgram.Entities;
using ImcProgram.Service;
using ImcProgram.Utls;
using ImcProgram.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ImcProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utils utils = new Utils();
            Pacientes pacientes = new Pacientes();
            Manager manager = new Manager(pacientes);
            DataContext context = new DataContext();
            

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
                        // Console.WriteLine("= 1 =");
                        // string connectionString = "Server=localhost\\SQLEXPRESS;Database=IMCMANAGERDB;TrustServerCertificate=true;Trusted_Connection=true;";

                        // IDbConnection dbConnection = new SqlConnection(connectionString);

                        // string command = "SELECT GETDATE()";

                        // DateTime now = dbConnection.QuerySingle<DateTime>(command);

                        // Console.WriteLine(now);

                        // executando = false;

                        // Console.WriteLine("Insira o nome do paciente: ");
                        // pacientes.PaNome = Console.ReadLine();
                        // Console.WriteLine("Insira Peso do Paciente");
                        // string inputpeso = Console.ReadLine().Replace(',', ('.'));
                        // if (!double.TryParse(
                        //     inputpeso,
                        //     System.Globalization.NumberStyles.Any,
                        //     System.Globalization.CultureInfo.InvariantCulture,
                        //     out double peso))
                        // {
                        //     Console.WriteLine("Peso Inválido! ");
                        //     Console.ReadKey();
                        // }
                        // pacientes.PaPeso = peso;


                        // Console.WriteLine("Insira a altura do Paciente");
                        // string inputaltura = Console.ReadLine().Replace(',', '.');

                        // if (!double.TryParse(
                        //     inputaltura,
                        //     System.Globalization.NumberStyles.Any,
                        //     System.Globalization.CultureInfo.InvariantCulture,
                        //     out double altura))
                        // {
                        //     Console.WriteLine("Peso Inválido! ");
                        //     Console.ReadKey();
                        // }
                        // pacientes.PaAltura = altura;

                        // double imc = manager.CalcularImc();
                        // manager.ClassificarImc(imc);

                        // string classificacao = pacientes.PaClasse;

                        // Console.WriteLine("Qual o Objetivo do Paciente? ");
                        // string objetivo = Console.ReadLine();
                        // pacientes.PaObjetivo = objetivo;
                        // string commandCreate = @"INSERT INTO TPACIENTES (PNOME, PCLASSE, POBJETIVO, PPESO, PALTURA, PIMC, PCAD) 
                        //  VALUES (@nome,
                        //  @classe,
                        //  @objetivo,
                        //  @peso,
                        //  @altura,
                        //  @imc,
                        //  @cad
                        //  )";



                        // Console.WriteLine(commandCreate);

                        // int result = dbConnection.Execute(commandCreate, new{
                        //     nome = pacientes.PaNome,
                        //    classe = pacientes.PaClasse,
                        //     objetivo = pacientes.PaObjetivo,
                        //     peso = pacientes.PaPeso,
                        //     altura= pacientes.PaAltura,
                        //     imc = pacientes.PaImc,
                        //     cad = DateTime.Now,
                        // });
                            
                        

                        // Console.WriteLine(result);
                        // executando = false;
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
                        pacientes.PaPeso = peso;

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
                        pacientes.PaAltura = altura;

                        double imc = manager.CalcularImc();
                        Console.Clear();
                        Console.WriteLine($"O Peso é: {pacientes.PaPeso}");
                        Console.WriteLine($"A Altura é: {altura}");
                        Console.WriteLine($"O IMC é: {imc} ");
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