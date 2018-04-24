using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class OnibusItemCollection
    {
        private static List<OnibusItem> OnibusCollection { get; set; }

        public void SetList(List<OnibusItem> _list)
        {
            OnibusCollection = _list;
        }
        public void AddBus(OnibusItem _funcionario)
        {

            OnibusCollection.Add(_funcionario);
        }
        public void RemoveBus(OnibusItem _funcionario)
        {
            OnibusCollection.Remove(_funcionario);
        }
        public List<OnibusItem> GetFuncionarioOnibusCollection()
        {
            List<OnibusItem> list = OnibusCollection;
            return list;
        }
    }
}
