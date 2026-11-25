using System;
using Microsoft.EntityFrameworkCore;
using PessoaManager.Models;
using Microsoft.SqlServer;
using Microsoft.Data.SqlClient;
using PessoaManager.Context;
using System.Linq.Expressions;
using System.Linq;
using TesteApp.Ui;
using PessoaManager.Services;

namespace PessoaManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool executando = true;
            DataContext ef = new DataContext();
                PessoaService services = new PessoaService(ef);
            while (executando)
            {

                Console.WriteLine(" ==== Sistema de Gestao de Pessoas ==== ");
                Console.WriteLine(" == Escolha uma opção: == ");
                Console.WriteLine(" Selecione uma opção: ");
                Console.WriteLine(" 1 - Cadastrar Pessoa ");
                Console.WriteLine(" 2 - Exibir Pessoas ");
                Console.WriteLine(" 3 - Pesquisar Pessoa ");
                Console.WriteLine(" 4 - Editar Pessoa ");
                Console.WriteLine(" 5 - Excluir Pessoa ");
                Console.WriteLine(" 6 - Sair");
                int op;
                while (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Erro! Digite um numero válido");
                    Console.WriteLine("Pressione Qualquer tecla pra voltar!");
                    Console.ReadKey();
                }

                switch (op)
                {
                    case 1:
                        try
                        {
                            var novaPessoa = PessoaUI.LerDadosCadastro();
                            services.Cadastrar(novaPessoa);
                            PessoaUI.MostrarSucesso();
                        }
                        catch (Exception ex)
                        {
                            PessoaUI.MostrarErro(ex.Message);
                        }
                        break;
                    case 2:
                        var lista = services.ListarTodos();
                        PessoaUI.MostrarLista(lista);
                        break;
                    case 3:
                        try
                        {
                            string nomeBusca = PessoaUI.LerDadosBusca();

                            var resultados = services.BuscarNome(nomeBusca);
                            PessoaUI.MostrarLista(resultados);
                        }
                        catch (Exception ex)
                        {
                            PessoaUI.MostrarErro(ex.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            int id = PessoaUI.LerId();

                            var dados = PessoaUI.LerDadosEdicao();

                            services.Atualizar(id, dados.nome, dados.cpf, dados.endereco);
                            PessoaUI.MostrarSucesso();
                        }
                        catch (Exception ex)
                        {
                            PessoaUI.MostrarErro(ex.Message);
                        }
                        break;
                    case 5:
                        try
                        {
                            int id = PessoaUI.LerId();

                            if (PessoaUI.ConfimarExclusao())
                            {
                                services.Excluir(id);
                                PessoaUI.MostrarSucesso();
                            }
                        }
                        catch(Exception ex)
                        {
                            PessoaUI.MostrarErro(ex.Message);
                        }
                        break;
                    case 6:
                        if (PessoaUI.ConfirmarSaida())
                        {
                            executando = false;
                        }
                        Console.WriteLine("Pressione Qualquer Tecla para voltar!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Erro! Opção Inválida!");
                        Console.WriteLine("Pressione Qualquer tecla pra voltar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }


        }
    }
}
