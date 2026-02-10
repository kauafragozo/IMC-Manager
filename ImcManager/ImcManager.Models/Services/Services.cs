using System;
using ImcProgram.Entities;
using ImcProgram.Repository;
using Microsoft.IdentityModel.Tokens;


namespace ImcProgram.Service
{
    public class PacienteService
    {

        Paciente paciente1 = new Paciente();
        private readonly PacientesRepository _repo;

        public PacienteService (PacientesRepository repo)
        {
            _repo = repo;
        }

        public void Cadastrar(Paciente paciente)
        {
            paciente1.PaImc = paciente1.PaPeso / (paciente1.PaAltura * paciente1.PaAltura);
            paciente1.PaCad = DateTime.Now;

            _repo.Adicionar(paciente);
        }
        public double CalcularImc()
        {

            double ImcResultado = paciente1.PaPeso / (paciente1.PaAltura * paciente1.PaAltura);
            return ImcResultado;
        }

        public void ClassificarImc(double Imc)
        {

            if (Imc < 18.5)
            {
                paciente1.PaClasse = "Abaixo do Peso";
            }
            else if (Imc >= 18.5 && Imc < 25)
            {
                paciente1.PaClasse = "Peso Normal";
            }
            else if (Imc >= 25 && Imc < 30)
            {
                paciente1.PaClasse = "Sobre Peso";
            }
            else if (Imc >= 30 && Imc < 35)
            {
                paciente1.PaClasse = "Obesidade Grau I";
            }
            else if (Imc >= 35 && Imc < 40)
            {
                paciente1.PaClasse = "Obesidade Grau II";
            }
            else
            {
                paciente1.PaClasse = "Obesidade Grau III";
            }

        }



    }

}









