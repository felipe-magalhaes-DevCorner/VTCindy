using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class OnibusItemCollection : List<OnibusItem>
    {
        private static List<OnibusItem> OnibusCollection { get; set; }

        public void SetList(List<OnibusItem> _list)
        {
            OnibusCollection = _list;
        }

        public int COuntList()
        {
            return OnibusCollection.Count();
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
        public OnibusItemCollection GetFuncionarioOnibusCollectionToList()
        {

            return this;
        }
        public OnibusItemCollection MakeListTOCollection()
        {
            OnibusItemCollection collection = new OnibusItemCollection();
            foreach (OnibusItem onibus in OnibusCollection)
            {
                collection.Add(onibus);

            }
            return collection;

        }
    }
}
