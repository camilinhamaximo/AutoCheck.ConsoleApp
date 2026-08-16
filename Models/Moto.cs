using System.Collections.Generic;

namespace AutoCheck.ConsoleApp.Models
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(
            string marca,
            string modelo,
            int ano,
            double quilometragem,
            string cor,
            int cilindradas)
            : base(marca, modelo, ano, quilometragem, cor)
        {
            this.Cilindradas = cilindradas;
        }

        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> checklist = base.ObterChecklistObrigatorio();

            checklist.Add("Kit Transmissão/Corrente");
            checklist.Add("Manetes de Freio/Embreagem");
            checklist.Add("Pezinho Lateral");
            checklist.Add("Estrutura do Chassi");
            checklist.Add("Funcionamento a frio");

            return checklist;
        }
    }
}