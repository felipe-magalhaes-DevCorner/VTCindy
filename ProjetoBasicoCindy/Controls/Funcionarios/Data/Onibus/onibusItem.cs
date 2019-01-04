namespace ProjetoBasicoCindy
{
    public class OnibusItem
    {

        
        public int Idonibus { get; set; }
        public string Linha { get; set; }
        public string Cartao { get; set; }
        public double Preco { get; set; }
        

        //contrutor
        public OnibusItem(int idonibus = 1, string linha = null, string cartao = null, double preco = 1)
        {

            Idonibus = idonibus;
            Linha = linha;
            Cartao = cartao;
            Preco = preco;


        }

        


        


    }
}
