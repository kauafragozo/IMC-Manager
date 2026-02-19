using System;
using System.Data;
using IMCManager.Models;
using IMCManager.Services;
using IMCManager.Data;
using IMCManager.UI;
using Microsoft.Data.SqlClient;
using System.IO.Pipes;

namespace IMCManager
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
                        var lista = service.ListarTodos();
                        ImcUI.MostrarLista(lista);

                        break;
                    case 3:
                        string nomeBusca = ImcUI.LerDadosBusca();
                        var resultados = service.BuscarNome(nomeBusca);

                        ImcUI.MostrarLista(resultados);
                        break;
                    case 4:
                        try
                        {
                            int id = ImcUI.LerId();
                            var editados = ImcUI.LerDadosEdição();

                            service.Atualizar(id, editados.novoNome, editados.novoObjetivo, editados.novoPeso, editados.novoAltura);
                        }
                        catch (Exception ex)
                        {
                            ImcUI.ExibirErro(ex.Message);
                        }
                        break;
                    case 5:
                        try
                        {
                            int id = ImcUI.LerId();
                            if (ImcUI.ConfirmarExclusão())
                            {
                                service.Excluir(id);
                                ImcUI.ExibirSucesso();
                            }

                        }catch(Exception ex)
                        {
                            ImcUI.ExibirErro(ex.Message);
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        ImcUI.ConsultarClassificações();
                        break;
                    case 7:
                        var dados = ImcUI.LerDadosCalculoIMC();

                        decimal resultado = service.CalcularImc(dados.peso, dados.altura);
                        string classImc = service.ClassificarImc(resultado);
                        Console.WriteLine($"O IMC é: {resultado:F2} - Classificação: {classImc}");
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