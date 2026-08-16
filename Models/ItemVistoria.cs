namespace AutoCheck.ConsoleApp.Models
{
    public class ItemVistoria
    {
        public string Nome { get; set; }
        public string Status { get; set; }

        public ItemVistoria(string nome, string status)
        {
            this.Nome = nome;
            this.Status = status;
        }
    }
}