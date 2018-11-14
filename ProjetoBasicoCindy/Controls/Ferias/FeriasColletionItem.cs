using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy.Ferias

{
    /// <summary>
    /// Class to store all ferias items
    /// </summary>
    public class FeriasColletionItem : List<Ferias.FeriasItem>
    {
        //main list of ferias item
        private List<FeriasItem> ListaFerias = new List<FeriasItem>();
        //return the list
        public List<FeriasItem> getListFerias() => ListaFerias;
        //adds to list of ferias item
        public void AddtolistFerias(FeriasItem _feriasItem) => ListaFerias.Add(_feriasItem);
        //removes to list of ferias item
        public void RemoveListFerias(FeriasItem _feriasItem) => ListaFerias.Remove(_feriasItem);
        //celars list 
        public void ClearListFerias() => ListaFerias.Clear();
        public void SetList(List<Ferias.FeriasItem> _list) => ListaFerias = _list;
    }
}
