using System.Collections.Generic;

namespace ProjetoBasicoCindy.Vacina
{
    public class FuncionarioVaccinaColletion : List<Vacina>
    {
        public List<Vacina> ListaVacinas;

        public FuncionarioVaccinaColletion(List<Vacina> listaVacinas = null) => this.ListaVacinas = listaVacinas;

        public void SetList(List<Vacina> list) => ListaVacinas = list;
        public List<Vacina> GetListFerias() => ListaVacinas;
        //adds to list of ferias item
        public void AddtolistFerias(Vacina vacinaItem) => ListaVacinas.Add(vacinaItem);
        //removes to list of ferias item
        public void RemoveListFerias(Vacina vacinaItem) => ListaVacinas.Remove(vacinaItem);
        //celars list 
        public void ClearListFerias() => ListaVacinas.Clear();



    }
}
