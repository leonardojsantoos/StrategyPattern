namespace ExemploStrategy
{
    public class ProcessadorExame
    {
        private IAprovaExame estrategia;

        public ProcessadorExame(IAprovaExame estrategia)
        {
            this.estrategia = estrategia;
        }

        public void Processar(Exame exame)
        {
            estrategia.Aprovar(exame);
        }

        public void SetEstrategia(IAprovaExame novaEstrategia)
        {
            estrategia = novaEstrategia;
        }
    }
}