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
            Pacientes pacientes1 = new Pacientes();

            while (executando == true)
            {
                Console.WriteLine("Bem Vindo ao ImcManager - Gerenciador de Imc!");
                Console.Write("Primeiramente, Insira o Nome do Paciente:");
                pacientes1.Nome = Console.ReadLine();
                Console.WriteLine("Agora,Insira o peso (em kilogramas) do Paciente:");
                pacientes1.Peso = double.Parse(Console.ReadLine().Replace(",","."),CultureInfo.InvariantCulture);
                Console.WriteLine("Agora, Insira o Altura (em metros) do Paciente:");
                pacientes1.Altura =double.Parse(Console.ReadLine().Replace(",","."), CultureInfo.InvariantCulture);

                pacientes1.CalcularImc();

                Console.WriteLine(pacientes1.Imc);
                Console.Write(pacientes1.Classe);
                    
                
                
               


            }
            
        }
    }
}

