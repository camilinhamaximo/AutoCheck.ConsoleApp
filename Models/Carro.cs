using System.Collections.Generic;

namespace AutoCheck.ConsoleApp.Models
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public Carro(
            string marca,
            string modelo,
            int ano,
            double quilometragem,
            string cor,
            int quantidadePortas)
            : base(marca, modelo, ano, quilometragem, cor)
        {
            this.QuantidadePortas = quantidadePortas;
        }

        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> checklist = base.ObterChecklistObrigatorio();

            checklist.Add("Estepe e Macaco");
            checklist.Add("Triângulo de Sinalização");
            checklist.Add("Ar Condicionado Funcional");
            checklist.Add("Ar Quente Funcional");
            checklist.Add("Kit Multimídia Funcional");
            checklist.Add("Parabrisa Frontal e Dianteiro");
            checklist.Add("Motor");
            checklist.Add("Acabamento interno");

            return checklist;
        }
    }
}
