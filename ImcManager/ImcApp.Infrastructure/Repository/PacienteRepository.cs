using ImcProgram.Context;
using ImcProgram.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImcProgram.Repository
{
    public class PacientesRepository
    {


        private readonly string _connectionString;

        public PacientesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private readonly DataContextEF _context;

        public PacientesRepository(DataContextEF context)
        {
            _context = context;
        }

        public void Adicionar(Paciente paciente)
        {
             _context.Pacientes.Add(paciente);
             _context.SaveChanges();
        }

        public List<Paciente> VisualizarPacientes()
        { 
            return _context.Pacientes.ToList();
        }
        
        public Paciente PesquisarPaciente(int id)
        {
            return _context.Pacientes.Find(id);
        }

        public void Editar(Paciente paciente)
        {
             _context.Pacientes.Update(paciente);
             _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var pacienteBuscar = PesquisarPaciente(id);
            if (pacienteBuscar == null) { return; }

            _context.Pacientes.Remove(pacienteBuscar);
            _context.SaveChanges();
        }
    }
}