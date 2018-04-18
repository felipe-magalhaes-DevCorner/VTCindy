using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class OnibusItem
    {
        public OnibusItem(int idonibus, string linha, string cartao, string descricao)
        {
            _idonibus = idonibus;
            _linha = linha;
            _cartao = cartao;
            _descricao = descricao;
        }

        private int _idonibus { get; set; }
        private string _linha { get; set; }
        private string _cartao { get; set; }
        private string _descricao { get; set; }

    }
}
