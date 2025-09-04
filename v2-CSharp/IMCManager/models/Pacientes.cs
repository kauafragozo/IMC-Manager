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
       
        






    }
}
