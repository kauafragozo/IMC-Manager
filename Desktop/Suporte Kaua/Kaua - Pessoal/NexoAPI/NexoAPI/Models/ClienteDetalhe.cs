namespace NexoApi.Models
{
    public class ClienteDetalhe
    {
        public int Id{get; set;}
        public int CienteId{get;set;}
        public string Endereco { get; set;} = string.Empty;

        public int Numero { get;set;}
        public string Cidade { get; set;} = string.Empty;
        public string UF{get;set;}= string.Empty;
        public string Telefone { get; set;} = string.Empty;
        public string Email { get; set;} = string.Empty;


    }
}