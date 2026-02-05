using System;
using ImcProgram.Entities;
using Microsoft.IdentityModel.Tokens;


namespace ImcProgram.Service
{
    public class Manager
    {

        private Pacientes paciente;

        public Manager(Pacientes paciente)
        {
            this.paciente = paciente;
        }
        public double CalcularImc()
        {

            double ImcResultado = paciente.PaPeso / (paciente.PaAltura * paciente.PaAltura);
            return ImcResultado;
        }

        public void ClassificarImc(double Imc)
        {

            if (Imc < 18.5)
            {
                paciente.PaClasse = "Abaixo do Peso";
            }
            else if (Imc >= 18.5 && Imc < 25)
            {
                paciente.PaClasse = "Peso Normal";
            }
            else if (Imc >= 25 && Imc < 30)
            {
                paciente.PaClasse = "Sobre Peso";
            }
            else if (Imc >= 30 && Imc < 35)
            {
                paciente.PaClasse = "Obesidade Grau I";
            }
            else if (Imc >= 35 && Imc < 40)
            {
                paciente.PaClasse = "Obesidade Grau II";
            }
            else
            {
                paciente.PaClasse = "Obesidade Grau III";
            }

        }



    }

}









