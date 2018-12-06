using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy.Ferias
{
    public class FeriasItem
    {
        
        public DateTime InicioFerias { get; set; }
        public DateTime fimFerias { get; set; }

        public FeriasItem(DateTime inicioFerias, DateTime FimFerias)
        {

            InicioFerias = inicioFerias;
            fimFerias = FimFerias;
        }

    }
}
