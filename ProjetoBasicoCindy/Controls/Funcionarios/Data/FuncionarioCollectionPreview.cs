using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class FuncionarioCollectionPreview
    {

        private static List<FuncionarioItemPreview> FuncionarioColPreview { get; set; }

        public void SetList(List<FuncionarioItemPreview> _list)
        {
            FuncionarioColPreview = _list;
        }
        public void AddFuncionario(FuncionarioItemPreview _funcionario)
        {

            FuncionarioColPreview.Add(_funcionario);
        }
        public void RemoveFuncionario(FuncionarioItemPreview _funcionario)
        {
            FuncionarioColPreview.Remove(_funcionario);
        }
        public List<FuncionarioItemPreview> GetFuncionariosList()
        {
            List<FuncionarioItemPreview> list = FuncionarioColPreview;
            return list;



        }

    }
}
