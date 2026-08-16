using System.Collections.Generic;

namespace AutoCheck.ConsoleApp.Models
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Quilometragem { get; set; }
        public string Cor { get; set; }


        public List<ItemVistoria> VistoriaRealizada { get; set; }

        public Veiculo(string marca, string modelo, int ano, double quilometragem, double cor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Quilometragem = quilometragem;
            this.Cor = cor;
            this.VistoriaRealizada = new List<ItemVistoria>();
        }

        public void AdicionarItemVistoriado(string nome, string status)
        {
            ItemVistoria item = new ItemVistoria(nome, status);

            this.VistoriaRealizada.Add(item);
        }

        public virtual List<string> ObterChecklistObrigatorio()
        {
            List<string> checklist = new List<string>();

            checklist.Add("Nível de Óleo do Motor");
            checklist.Add("Bateria e Sistema Elétrico");
            checklist.Add("Documentação Regularizada");
            checklist.Add("Pneus");
            checklist.Add("Faróis");
            checklist.Add("Lataria");
            checklist.Add("Freios");
            checklist.Add("Suspensão");
            checklist.Add("Luzes de sinalização");


            return checklist;
        }
    }
}