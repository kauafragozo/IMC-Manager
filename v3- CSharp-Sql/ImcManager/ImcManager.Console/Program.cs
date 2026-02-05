using System;
using ImcProgram.Entities;
using ImcProgram.Service;
using ImcProgram.Utls;

namespace ImcProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utils utils = new Utils();

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
                        Console.WriteLine("= 1 =");
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
                        Console.WriteLine("= 7 =");
                        break;
                    case 8:
                        Console.Clear();
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("= Erro: Opção Inválida! =");
                        break;
                }

            }




            // Pacientes pacientes = new Pacientes();
            // Manager manager = new Manager(pacientes);

            // Console.WriteLine("Insira o Peso do Paciente: ");
            // double peso = double.Parse(Console.ReadLine());
            // pacientes.PaPeso = peso;

            // Console.WriteLine("Insira a Altura do Paciente: ");
            // double altura = double.Parse(Console.ReadLine());
            // pacientes.PaAltura = altura;

            // double imc = manager.CalcularImc();
            // Console.WriteLine($"O Peso é: {peso}");
            // Console.WriteLine($"A Altura é: {altura}");
            // Console.WriteLine($"O IMC é: {imc} ");



        }
    }
}