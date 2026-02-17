using System;
using System.Data;
using ImcProgram.Entities;
using ImcProgram.Service;
using ImcProgram.Context;
using ImcProgram.UI;
using Microsoft.Data.SqlClient;

namespace ImcProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== IMC Manager ===");
            Console.WriteLine("== Seja bem-vindo(a)! ==");

            Console.WriteLine("Aperte qualquer tecla para continuar!");
            Console.ReadKey();

            DataContextEF ef = new DataContextEF();
            PacienteService service = new PacienteService(ef);

            bool executando = true;
            while (executando)
            {
                ImcUI.ExibirMenu();
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        try
                        {
                            var novoPaciente = ImcUI.LerDadosCadastro();
                            service.Cadastrar(novoPaciente.nome, novoPaciente.objetivo, novoPaciente.peso, novoPaciente.altura);
                            ImcUI.ExibirSucesso();
                        }
                        catch (Exception ex)
                        {
                            ImcUI.ExibirErro(ex.Message);
                        }
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
                        ImcUI.ConsultarClassificações();
                        break;
                    case 7:
                        var dados = ImcUI.LerDadosCalculoIMC();

                        double resultado = service.CalcularImc(dados.peso, dados.altura);
                        string classImc = service.ClassificarImc(resultado);
                        Console.WriteLine($"O IMC é: {resultado} - Classificação: {classImc}");
                        Console.ReadKey();
                        break;
                    case 8:
                        if (ImcUI.Sair())
                        {
                            executando = false;
                        }
                        break;
                    default:
                        ImcUI.OpInválida();
                        break;
                }

            }



        }
    }
}