using System;
using System.Collections.Generic;
using IMCManager.Models;
using System.Globalization;

namespace IMCManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool executando = true;
            List<Pacientes> pacientes = new List<Pacientes>();

            int op = 0;
            int exec = 0;

            while (executando == true)
            {
                Console.WriteLine("Bem Vindo ao ImcManager - Gerenciador de Imc!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar Paciente");
                Console.WriteLine("2 - Visualizar Pacientes");
                Console.WriteLine("3 - Pesquisar Pacientes");
                Console.WriteLine("4 - Excluir Paciente");
                Console.WriteLine("5 - Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Pacientes novo = new Pacientes();
                        novo.CadastrarPaciente();
                        pacientes.Add(novo);
                        Console.WriteLine($"Paciente {novo.Nome} cadastrado com sucesso!");


                        Console.WriteLine("Deseja Realizar outra Operação?");
                        Console.WriteLine("1 - Sim");
                        Console.WriteLine("2 - Não");

                        exec = int.Parse(Console.ReadLine());
                        if (exec == 1)
                        {
                            executando = true;
                        }
                        else
                        {
                            executando = false;
                        }

                        break;
                    case 2:
                        int contador = 1;
                        foreach (var paciente in pacientes)
                        {
                            Console.WriteLine($"Paciente #{contador}");
                            Console.WriteLine($"Nome: {paciente.Nome}");
                            Console.WriteLine($"Classe: {paciente.Classe}");
                            Console.WriteLine($"Objetivo: {paciente.Objetivo}");
                            Console.WriteLine($"Peso: {paciente.Peso}");
                            Console.WriteLine($"Altura: {paciente.Altura}");
                            Console.WriteLine($"IMC: {paciente.Imc}");
                            Console.WriteLine("-------------");

                            
                        }
                        break;
                    case 3:

                        Console.WriteLine("Qual o Nome do Paciente que voce deseja buscar?");
                        string buscaNome = Console.ReadLine();

                        for (int i = 0; i < pacientes.Count; i++)
                        {
                            if (pacientes[i].Nome.Equals(buscaNome, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"Paciente #{i + 1}");
                                Console.WriteLine($"Nome: {pacientes[i].Nome}");
                                Console.WriteLine($"Classe: {pacientes[i].Classe}");
                                Console.WriteLine($"Objetivo: {pacientes[i].Objetivo}");
                                Console.WriteLine($"Peso: {pacientes[i].Peso}");
                                Console.WriteLine($"Altura: {pacientes[i].Altura}");
                                Console.WriteLine($"IMC: {pacientes[i].Imc}");
                                Console.WriteLine("-------------");
                            }

                        }
                        Console.WriteLine("Deseja Realizar outra Operação?");
                            Console.WriteLine("1 - Sim");
                            Console.WriteLine("2 - Não");

                            exec = int.Parse(Console.ReadLine());
                            if (exec == 1)
                            {
                                executando = true;
                            }
                            else
                            {
                                executando = false;
                            }
                        break;
                    case 4:
                        int contador2 = 1;
                        foreach (var paciente in pacientes)
                        {
                            Console.WriteLine($"Paciente #{contador2}");
                            Console.WriteLine($"Nome: {paciente.Nome}");
                            Console.WriteLine($"Classe: {paciente.Classe}");
                            Console.WriteLine($"Objetivo: {paciente.Objetivo}");
                            Console.WriteLine($"Peso: {paciente.Peso}");
                            Console.WriteLine($"Altura: {paciente.Altura}");
                            Console.WriteLine($"IMC: {paciente.Imc}");
                            Console.WriteLine("-------------");

                        }
                        Console.WriteLine("Qual o Número do paciente que deseja Editar?");
                        int numEditar = int.Parse(Console.ReadLine());

                        pacientes.RemoveAt(numEditar - 1);

                        Console.WriteLine("Deseja Realizar outra Operação?");
                            Console.WriteLine("1 - Sim");
                            Console.WriteLine("2 - Não");

                            exec = int.Parse(Console.ReadLine());
                            if (exec == 1)
                            {
                                executando = true;
                            }
                            else
                            {
                                executando = false;
                            }
                        break;
                    default:
                        executando = false;
                        break;


                }











            }

        }
    }
}

