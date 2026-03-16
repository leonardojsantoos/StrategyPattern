using System;

namespace ExemploStrategy
{
    public class AprovaRaioX : IAprovaExame
    {
        public void Aprovar(Exame exame)
        {
            if (exame.Nome.Contains("Tórax"))
            {
                Console.WriteLine($"Raio-X '{exame.Nome}' aprovado!");
            }
            else
            {
                Console.WriteLine($"Raio-X '{exame.Nome}' reprovado!");
            }
        }
    }
}