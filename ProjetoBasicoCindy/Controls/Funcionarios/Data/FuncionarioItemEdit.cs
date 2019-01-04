using System.Collections.Generic;

namespace ProjetoBasicoCindy
{
    public class FuncionarioItemEdit
    {
        private static FuncionarioItem  FuncionarioEdit { get; set; }

        public void SetFuncionarioEdit(FuncionarioItem funcionario)
        {
            FuncionarioEdit = funcionario;
            FuncionarioEdit.Name = "felipe";
        }

        public FuncionarioItem GetFuncionarioEdit() => FuncionarioEdit;

        public List<OnibusItem> GetBusEdit() => FuncionarioEdit.Onibus;
        public List<Ferias.FeriasItem> GetFeriasEdit() => FuncionarioEdit.Ferias;




    }
}
