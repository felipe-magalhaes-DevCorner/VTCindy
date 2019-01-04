using System.Collections.Generic;

namespace ProjetoBasicoCindy.Ferias

{
    /// <summary>
    /// Class to store all ferias items
    /// </summary>
    public class FeriasColletionItem : List<FeriasItem>
    {
        //main list of ferias item
        public List<FeriasItem> ListaFerias = new List<FeriasItem>();
        //return the list
        public List<FeriasItem> GetListFerias() => ListaFerias;
        //adds to list of ferias item
        public void AddtolistFerias(FeriasItem feriasItem) => ListaFerias.Add(feriasItem);
        //removes to list of ferias item
        public void RemoveListFerias(FeriasItem feriasItem) => ListaFerias.Remove(feriasItem);
        //celars list 
        public void ClearListFerias() => ListaFerias.Clear();
        public void SetList(List<FeriasItem> list) => ListaFerias = list;
    }
}
