using System;
using System.Collections.Generic;
using System.Globalization;

namespace IMCManager.Models
{
    public class Pacientes
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public string Objetivo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Imc { get; set; }

        public void CalcularImc()
        {
            Imc = Peso / (Altura * Altura);


            if (Imc < 18.5)
            {
                Classe = "Abaixo do Peso";
            }
            else if (Imc < 25 && Imc >= 18.5)
            {
                Classe = "Peso Normal";
            }
            else if (Imc < 30 && Imc >= 25)
            {
                Classe = " Sobre Peso";
            }
            else if (Imc < 35 && Imc >= 30)
            {
                Classe = "Obesidade Grau I";
            }
            else if (Imc < 40 && Imc >= 35)
            {
                Classe = "Obesidade Grau II";
            }
            else
            {
                Classe = "Obesidade Grau III";
            }

        }

        public void CadastrarPaciente()
        {
            Console.Write("Primeiramente, Insira o Nome do Paciente:");
            this.Nome = Console.ReadLine();

            Console.WriteLine("Agora,Insira o peso (em kilogramas) do Paciente:");
            this.Peso = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
            Console.WriteLine("Agora, Insira o Altura (em metros) do Paciente:");
            this.Altura = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual o Objetivo do Paciente?");
            Console.WriteLine("1 - Perder Peso");
            Console.WriteLine("2 - Manter Peso");
            Console.WriteLine("3 - Ganhar Massa Muscular");
            Console.WriteLine("4 - Melhorar Condicionamento Físico");
            Objetivo = Console.ReadLine();

            switch (Objetivo)
            {
                case "1":
                    this.Objetivo = "Perder Peso";
                    break;
                case "2":
                    this.Objetivo = "ManterPeso";
                    break;
                case "3":
                    this.Objetivo = "Ganhar Massa Muscular";
                    break;
                case "4":
                    this.Objetivo = "Melhorar Condicionamento Físico";
                    break;
                default:
                    Console.WriteLine("Erro: Opção Inválida!");
                    break;

            }
            CalcularImc();

        }
        public void EditarPacientes()
        {
            Console.WriteLine("Digite o novo nome do Paciente (Enter mantém o mesmo nome!):");
            Console.WriteLine("Digite o novo Peso do Paciente");
            
        }





    }
}
