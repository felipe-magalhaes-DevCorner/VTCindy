namespace ProjetoBasicoCindy.Vacina
{
    public class Vacina
    {
        public string Nome;
        public VacinaInfo Dados = new VacinaInfo();
        public int Dose;


        public Vacina(string nome, VacinaInfo dados, int dose)
        {
            Nome = nome;
            Dados = dados;
            Dose = dose;
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
