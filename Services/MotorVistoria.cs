using AutoCheck.ConsoleApp.Models;

namespace AutoCheck.ConsoleApp.Services
{
    public class MotorVistoria
    {
        public int CalcularPontuacao(Veiculo veiculo)
        {
            int pontuacao = 0;

            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                if (item.Status == "Bom")
                {
                    pontuacao += 10;
                }
                else if (item.Status == "Regular")
                {
                    pontuacao += 5;
                }
                else if (item.Status == "Ruim")
                {
                    pontuacao += 0;
                }
            }

            return pontuacao;
        }
    }
}