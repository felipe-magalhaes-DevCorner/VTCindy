using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class FuncionarioItemCollection        
    {

        public static List<FuncionarioItem> FuncionarioCollection { get; set; }


        public void SetList(List<FuncionarioItem> _list)
        {
            FuncionarioCollection = _list;
        }
        public void AddFuncionario(FuncionarioItem _funcionario)
        {

            FuncionarioCollection.Add(_funcionario);
        }
        public void RemoveFuncionario(FuncionarioItem _funcionario)
        {
            FuncionarioCollection.Remove(_funcionario);
        }
        public List<FuncionarioItem> GetFuncionariosList()
        {
            List<FuncionarioItem> list = FuncionarioCollection;
            return list;
        }


    }
}
