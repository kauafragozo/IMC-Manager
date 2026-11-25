using PessoaManager.Models;
namespace TesteApp.Ui
{
    public static class PessoaUI
    {

        public static Pessoa LerDadosCadastro()
        {
            Console.Clear();
            Console.WriteLine("=== CADASTRO DE PESSOA ===");

            Console.WriteLine("Digite o Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o Endereço");
            string endereco = Console.ReadLine();

            return new Pessoa
            {
                Nome = nome,
                CPF = cpf,
                Endereco = endereco
            };
        }

        public static string LerDadosBusca()
        {
            Console.Clear();
            Console.WriteLine("Qual Nome ou inicial da Pessoa que deseja buscar?");
            return Console.ReadLine();

        }

        public static int LerId()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da Pessoa: ");
            int.TryParse(Console.ReadLine(), out int id);
            return id;
        }

        public static (string nome, string cpf, string endereco)  LerDadosEdicao()
        {
            Console.WriteLine("Qual o novo Nome? (Deixar em branco para manter o mesmo!)");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o novo CPF? (Deixar em branco para manter o mesmo!)");
            string cpf = Console.ReadLine();
            Console.WriteLine("Qual o novo Endereço? (Deixar em branco para manter o mesmo!)");
            string endereco = Console.ReadLine();

            return (nome, cpf, endereco);
            
        }

        public static void MostrarLista(List<Pessoa> pessoas)
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Pessoas ===");

            if (!pessoas.Any())
            {
                Console.WriteLine("Nenhum Registro Encontrado! ");
            }
            else
            {
                foreach (var p in pessoas)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"| ID: {p.Id} | Nome: {p.Nome} | CPF: {p.CPF} | Endereço: {p.Endereco} |");
                    Console.WriteLine("------------------------------------");
                }
                Console.ReadKey();
            }

        }

        public static bool ConfimarExclusao()
        {
            Console.Clear();
            Console.WriteLine("Tem Certeza que deseja Excluir? (s/n)");
            string resposta = Console.ReadLine();

            return resposta.ToLower() == "s";
        }

        public static bool ConfirmarSaida()
        {
            Console.Clear();
            Console.WriteLine("Tem certeza que deseja Sair?");
            string sair = Console.ReadLine();

            return sair.ToLower() == "s";
        }

        public static void MostrarSucesso()
        {
            Console.WriteLine("Pessoa Cadastrada com Sucesso!");
            Console.ReadKey();
        }

        public static void MostrarErro(string mensagem)
        {
            Console.WriteLine($"Erro: {mensagem}");
            Console.ReadKey();
        }

    }
}