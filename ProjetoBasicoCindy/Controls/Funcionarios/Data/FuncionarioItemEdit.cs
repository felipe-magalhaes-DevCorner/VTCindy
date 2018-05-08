using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class FuncionarioItemEdit
    {
        private static FuncionarioItem  FuncionarioEdit { get; set; }

        public void SetFuncionarioEdit(FuncionarioItem _funcionario)
        {
            FuncionarioEdit = _funcionario;
        }
        public FuncionarioItem GetFuncionarioEdit()
        {
            return FuncionarioEdit;
        }
        public List<OnibusItem> getBusEdit()
        {
            return FuncionarioEdit._onibus;
        }


    }
}
