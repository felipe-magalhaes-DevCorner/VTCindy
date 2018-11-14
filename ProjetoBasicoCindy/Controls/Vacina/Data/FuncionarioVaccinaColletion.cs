using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy.Vacina
{
    public class FuncionarioVaccinaColletion : List<Vacina>
    {
        public List<Vacina> listaVacinas;

        public FuncionarioVaccinaColletion(List<Vacina> listaVacinas = null) => this.listaVacinas = listaVacinas;

        public void SetList(List<Vacina> _list) => listaVacinas = _list;
        public List<Vacina> getListFerias() => listaVacinas;
        //adds to list of ferias item
        public void AddtolistFerias(Vacina _vacinaItem) => listaVacinas.Add(_vacinaItem);
        //removes to list of ferias item
        public void RemoveListFerias(Vacina _vacinaItem) => listaVacinas.Remove(_vacinaItem);
        //celars list 
        public void ClearListFerias() => listaVacinas.Clear();



    }
}
