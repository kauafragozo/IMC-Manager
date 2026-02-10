
namespace ImcProgram.Utls
{


    public class Utils
    {

        public void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("=== IMC Manager ===");
            Console.WriteLine("== Selecione uma Operação:  ==");
            Console.WriteLine("= 1. Cadastrar Paciente =");
            Console.WriteLine("= 2. Exibir Pacientes =");
            Console.WriteLine("= 3. Pesquisar Paciente =");
            Console.WriteLine("= 4. Editar Paciente =");
            Console.WriteLine("= 5. Excluir Paciente =");
            Console.WriteLine("= 6. Consultar Classificações =");
            Console.WriteLine("= 7. Calcular IMC =");
            Console.WriteLine("= 8. Sair =");
        }


        public void ConsultarClassificações()
        {
            Console.Clear();
            Console.WriteLine("= Consulta de Classificações: =");
            Console.WriteLine("IMC menor que 18.5 = Abaixo do Peso ");
            Console.WriteLine("IMC maior ou igual que 18.5 && IMC menor que 25 = Peso Normal ");
            Console.WriteLine("IMC maior ou igual que 25 && IMC menor que 30 = Sobre Peso ");
            Console.WriteLine("IMC maior ou igual que 30 && IMC menor que 35 =  Obesidade Grau III");
            Console.WriteLine("IMC maior ou igual que 35 && IMC menor que 40 = Obesidade Grau II");
            Console.WriteLine("IMC maior que 40 = Obesidade Grau III");
            Console.WriteLine("= Pressione qualquer tecla para voltar! =");
        }


        public void AtribuirObjetivo(string paObjetivo)
        {
            Console.Clear();
            Console.WriteLine("1 - Perder Peso");
            Console.WriteLine("2 - Manter Peso ");
            Console.WriteLine("3 - Ganhar Massa Muscular");
            Console.WriteLine("4 - Melhorar Condicionamento Fisico");
            int objetivo = Convert.ToInt32(Console.ReadLine());

            switch (objetivo)
            {
                case 1:
                paObjetivo = "1 - Perder Peso";
                break;
                case 2:
                paObjetivo = "2 - Manter Peso ";
                break;
                case 3:
                paObjetivo = "3 - Ganhar Massa Muscular";
                break;
                case 4:
                paObjetivo = "4 - Melhorar Condicionamento Fisico";
                break;
                default:
                Console.WriteLine("Erro! Opção Inválida!");
                break;

            }
        }


    }










}