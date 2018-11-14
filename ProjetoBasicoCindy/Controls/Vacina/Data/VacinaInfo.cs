using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy.Vacina
{
    public  class VacinaInfo
    {
        public DateTime Data;
        public string Lote;
        public string Unidade;

        public VacinaInfo(DateTime data, string lote, string unidade)
        {
            Data = data;
            Lote = lote;
            Unidade = unidade;
        }
        public VacinaInfo()
        {
            this.Data = Convert.ToDateTime("15/03/2018");
            this.Lote = "00114564";
            this.Unidade = "Venda Nova";
        }
        public VacinaInfo(int teste)
        {
            Data = Convert.ToDateTime("15/07/2018");
            Lote = "00114565";
            Unidade = "Sao paulo";
        }


    }
}
