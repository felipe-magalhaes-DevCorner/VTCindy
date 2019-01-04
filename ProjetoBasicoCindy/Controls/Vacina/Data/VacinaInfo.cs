using System;

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
            Data = Convert.ToDateTime("15/03/2018");
            Lote = "00114564";
            Unidade = "Venda Nova";
        }
        public VacinaInfo(int teste)
        {
            Data = Convert.ToDateTime("15/07/2018");
            Lote = "00114565";
            Unidade = "Sao paulo";
        }


    }
}
