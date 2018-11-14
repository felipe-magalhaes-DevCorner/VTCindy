using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy.Vacina
{
    public class Vacina
    {
        public string _nome;
        public VacinaInfo _dados = new VacinaInfo();
        public int _dose;


        public Vacina(string nome, VacinaInfo dados, int dose)
        {
            _nome = nome;
            _dados = dados;
            _dose = dose;
        }
        //public Vacina()
        //{
        //    this.nome = "HebB";
        //    VacinaInfo vacinainfo = new VacinaInfo();            
        //    this.dados.Add(vacinainfo);
        //    this.dose = 1;
        //}
        //public Vacina(int dose)
        //{
        //    this.nome = "HebB";
        //    VacinaInfo vacinainfo = new VacinaInfo();
        //    this.dados.Add(vacinainfo);
        //    dose = 2;
        //}



    }



}
