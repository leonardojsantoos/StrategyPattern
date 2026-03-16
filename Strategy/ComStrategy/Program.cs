using System;

namespace ExemploStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Exame exameSangue = new Exame { Nome = "Hemograma Completo" };
            Exame exameRaioX = new Exame { Nome = "Raio-X de Tórax" };
            Exame exameSangueErrado = new Exame { Nome = "Coleta de Sangue" };
            Exame exameRaioXErrado = new Exame { Nome = "Raio-X de Braço" };

            // Processador começa com estratégia de exame de sangue
            ProcessadorExame processador = new ProcessadorExame(new AprovaExameSangue());
            processador.Processar(exameSangue);        // aprovado
            processador.Processar(exameSangueErrado);  // reprovado

            // Troca para estratégia de Raio-X
            processador.SetEstrategia(new AprovaRaioX());
            processador.Processar(exameRaioX);         // aprovado
            processador.Processar(exameRaioXErrado);   // reprovado

            Console.ReadLine();
        }
    }
}