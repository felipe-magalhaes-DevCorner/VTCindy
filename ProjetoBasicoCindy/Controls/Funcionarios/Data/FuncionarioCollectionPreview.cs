using System.Collections.Generic;

namespace ProjetoBasicoCindy
{
    public class FuncionarioCollectionPreview : List<OnibusItem>
    {

        private static List<FuncionarioItemPreview> FuncionarioColPreview { get; set; }

        public void SetList(List<FuncionarioItemPreview> list)
        {
            FuncionarioColPreview = list;
        }
        public void AddFuncionario(FuncionarioItemPreview funcionario)
        {

            FuncionarioColPreview.Add(funcionario);
        }
        public void RemoveFuncionario(FuncionarioItemPreview funcionario)
        {
            FuncionarioColPreview.Remove(funcionario);
        }
        public List<FuncionarioItemPreview> GetFuncionariosList()
        {
            List<FuncionarioItemPreview> list = FuncionarioColPreview;
            return list;



        }

    }
}
