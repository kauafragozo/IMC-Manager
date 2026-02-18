using System;
using IMCManager.Data;
using IMCManager.Models;
using IMCManager.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace IMCManager.Services
{
    public class PacienteService
    {

        private readonly DataContextEF _context;

        public PacienteService(DataContextEF context)
        {
            _context = context;
        }

        Paciente paciente = new Paciente();
        public decimal CalcularImc(decimal peso, decimal altura)
        {
            if (peso <= 0) { throw new Exception("Peso deve ser maior que zero!"); }
            if (altura <= 0) { throw new Exception("Altura deve ser maior que zero!"); }
            decimal Imc = peso / (altura * altura);
            return Imc;
        }


        public string ClassificarImc(decimal Imc)
        {

            if (Imc < 18.5m) { return "Abaixo do Peso"; }
            else if (Imc < 25m) { return "Peso Normal"; }
            else if (Imc < 30m) { return "Sobre Peso"; }
            else if (Imc < 35m) { return "Obesidade Grau I"; }
            else if (Imc < 40m) { return "Obesidade Grau II"; }
            else { return "Obesidade Grau III"; }
        }

        public void Cadastrar(string nome, string objetivo, decimal peso, decimal altura)
        {
            if(altura <= 0 ){ throw new InvalidOperationException("Altura Inválida");}
            if(peso <= 0){ throw new InvalidOperationException("Peso Inválido");}

            decimal imc = peso / (altura * altura);

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

        public List<Paciente> ListarTodos()
        {
            return _context.Pacientes.ToList();
        }

        public List<Paciente> BuscarNome(string nome)
        {
             if(string.IsNullOrWhiteSpace(nome))
             return new List<Paciente>();

             return _context.Pacientes.Where(p => p.PNome.Contains(nome)).OrderBy(p => p.PNome).ToList();


        }

    
    }

}









