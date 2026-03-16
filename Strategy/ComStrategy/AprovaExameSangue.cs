using System;

namespace ExemploStrategy
{
    public class AprovaExameSangue : IAprovaExame
    {
        public void Aprovar(Exame exame)
        {
            if (exame.Nome.Contains("Hemograma"))
            {
                Console.WriteLine($"Exame de sangue '{exame.Nome}' aprovado!");
            }
            else
            {
                Console.WriteLine($"Exame de sangue '{exame.Nome}' reprovado!");
            }
        }
    }
}