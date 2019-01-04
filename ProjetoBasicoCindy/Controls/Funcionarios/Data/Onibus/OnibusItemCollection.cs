using System.Collections.Generic;
using System.Linq;

namespace ProjetoBasicoCindy
{
    public class OnibusItemCollection : List<OnibusItem>
    {
        private static List<OnibusItem> OnibusCollection { get; set; }

        public void SetList(List<OnibusItem> list)
        {
            OnibusCollection = list;
        }

        public int COuntList()
        {
            return OnibusCollection.Count();
        }




        public void AddBus(OnibusItem funcionario)
        {

            OnibusCollection.Add(funcionario);
        }
        public void RemoveBus(OnibusItem funcionario)
        {
            OnibusCollection.Remove(funcionario);
        }
        public void RemoveBusbyId(int idList)
        {
            OnibusCollection.RemoveAt(idList);
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
        public OnibusItemCollection MakeListToCollection()
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
