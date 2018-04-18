using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class OnibusItemCollection
    {
        public static List<OnibusItem> OnibusCollection { get; set; }

        public void SetList(List<OnibusItem> _list)
        {
            OnibusCollection = _list;
        }
        public void AddFuncionario(OnibusItem _funcionario)
        {

            OnibusCollection.Add(_funcionario);
        }
        public void RemoveFuncionario(OnibusItem _funcionario)
        {
            OnibusCollection.Remove(_funcionario);
        }
        public List<OnibusItem> GetFuncionariosList()
        {
            List<OnibusItem> list = OnibusCollection;
            return list;
        }
    }
}
