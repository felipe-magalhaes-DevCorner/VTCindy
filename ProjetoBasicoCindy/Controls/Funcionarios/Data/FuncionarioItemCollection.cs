using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public static class FuncionarioItemCollection
    {
        private static List<FuncionarioItem> FuncionarioCollection { get; set; }

        public static  void AddFuncionario(FuncionarioItem _funcionario)
        {
            FuncionarioCollection.Add(_funcionario);
        }
        public static void RemoveFuncionario(FuncionarioItem _funcionario)
        {
            FuncionarioCollection.Remove(_funcionario);
        }
        public static List<FuncionarioItem> GetFuncionariosList()
        {
            List<FuncionarioItem> list = FuncionarioCollection;
            return list;
        }


    }
}
