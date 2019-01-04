using System;

namespace ProjetoBasicoCindy.Ferias
{
    public class FeriasItem
    {
        
        public DateTime InicioFerias { get; set; }
        public DateTime FimFerias { get; set; }

        public FeriasItem(DateTime inicioFerias, DateTime fimFerias)
        {

            InicioFerias = inicioFerias;
            this.FimFerias = fimFerias;
        }

    }
}
