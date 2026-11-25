using System.Linq.Expressions;
using PessoaManager.Context;
using PessoaManager.Models;

namespace PessoaManager.Services
{
    public class PessoaService
    {
        private readonly DataContext _context;
        public PessoaService(DataContext context)
        {
            _context = context;
        }

        public void Cadastrar(Pessoa pessoa)
        {
            if (_context.Pessoas.Any(p => p.CPF == pessoa.CPF))
            {
                throw new Exception("Já existe uma Pessoa com esse CPF!");
            }
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public List<Pessoa> ListarTodos()
        {
            return _context.Pessoas.ToList();
        }
    

    public List<Pessoa> BuscarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return new List<Pessoa>();

            return _context.Pessoas.Where(p => p.Nome.Contains(nome)).OrderBy(p => p.Nome).ToList();
        }

        public void Atualizar(int id, string novoNome, string novoCpf, string novoEndereco)
        {
            var pessoa = _context.Pessoas.FirstOrDefault(p => p.Id == id);
            if(pessoa == null)
            {
                throw new Exception("Pessoa não encontrada! ");
            }
            if (!string.IsNullOrWhiteSpace(novoNome))
            {
                pessoa.Nome = novoNome;
            }

            if (!string.IsNullOrWhiteSpace(novoCpf))
            {
                pessoa.CPF = novoCpf;
            }
            if (!string.IsNullOrWhiteSpace(novoEndereco))
            {
                pessoa.Endereco = novoEndereco;
            }
            _context.SaveChanges();
            
        }

        public void Excluir(int id)
        {
            var pessoa = _context.Pessoas.FirstOrDefault(p => p.Id == id);
            if(pessoa == null)
            {
                throw new Exception ("Pessoa não Encontrada! ");

            }
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }
    }
}