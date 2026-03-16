using System;

namespace ExemploSemStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Exame exameSangue = new Exame { Tipo = "Sangue" };
            Exame exameRaioX = new Exame { Tipo = "RaioX" };

            ProcessadorExame processador = new ProcessadorExame();

            processador.ProcessarExame(exameSangue);
            processador.ProcessarExame(exameRaioX);

            Console.ReadLine();
        }
    }
}