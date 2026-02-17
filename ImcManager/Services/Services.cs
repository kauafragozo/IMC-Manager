using System;
using ImcProgram.Context;
using ImcProgram.Entities;
using ImcProgram.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace ImcProgram.Service
{
    public class PacienteService
    {

        private readonly DataContextEF _context;

        public PacienteService(DataContextEF context)
        {
            _context = context;
        }

        Paciente paciente = new Paciente();
        public double CalcularImc(double peso, double altura)
        {
            if (peso <= 0) { throw new Exception("Peso deve ser maior que zero!"); }
            if (altura <= 0) { throw new Exception("Altura deve ser maior que zero!"); }
            double Imc = peso / (altura * altura);
            return Imc;
        }


        public string ClassificarImc(double Imc)
        {

            if (Imc < 18.5) { return "Abaixo do Peso"; }
            else if (Imc < 25) { return "Peso Normal"; }
            else if (Imc < 30) { return "Sobre Peso"; }
            else if (Imc < 35) { return "Obesidade Grau I"; }
            else if (Imc < 40) { return "Obesidade Grau II"; }
            else { return "Obesidade Grau III"; }
        }

        public void Cadastrar(string nome, string objetivo, double peso, double altura)
        {
            if(altura <= 0 ){ throw new InvalidOperationException("Altura Inválida");}
            if(peso <= 0){ throw new InvalidOperationException("Peso Inválido");}

            double imc = peso / (altura * altura);

            string classificacao = ClassificarImc(imc);

            var paciente = new Paciente
            {
                PNome = nome,
                PClasse = classificacao,
                PObjetivo = objetivo,
                PPeso = peso,
                PAltura = altura,
                PImc = imc,
                PCad = DateTime.Now
                
            };
            try
            {
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
            }catch(Exception ex)
            {
                Console.WriteLine("Erro real: ");
                Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
                Console.ReadKey();
            }
        }



    }

}









