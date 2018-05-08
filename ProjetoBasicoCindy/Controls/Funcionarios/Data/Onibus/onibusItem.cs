using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class OnibusItem
    {

        
        public int _idonibus { get; set; }
        public string _linha { get; set; }
        public string _cartao { get; set; }
        public double _preco { get; set; }
        

        //contrutor
        public OnibusItem(int idonibus = 1, string linha = null, string cartao = null, double preco = 1)
        {
            _idonibus = idonibus;
            _linha = linha;
            _cartao = cartao;
            _preco = preco;


        }

        


        


    }
}
