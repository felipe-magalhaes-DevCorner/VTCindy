using System;
using System.Collections.Generic;

namespace ProjetoBasicoCindy
{
    public class FuncionarioItemCollection        
    {

        public static List<FuncionarioItem> FuncionarioCollection { get; set; }


        public void SetList(List<FuncionarioItem> list)
        {
            FuncionarioCollection = list;
        }
        public void AddFuncionario(FuncionarioItem funcionario)
        {

            FuncionarioCollection.Add(funcionario);
        }
        public void RemoveFuncionario(FuncionarioItem funcionario)
        {
            FuncionarioCollection.Remove(funcionario);
        }
        public List<FuncionarioItem> GetFuncionariosList()
        {
            List<FuncionarioItem> list = FuncionarioCollection;
            return list;
        }
        public FuncionarioItem ReturnFuncFromPreview(FuncionarioItemPreview funcionarioItemPreview)
        {
            foreach (var funcionarioItem in FuncionarioCollection)
            {
                if (funcionarioItem.IdFuncionario == Convert.ToInt32(funcionarioItemPreview.Idfuncionario))
                {
                    return funcionarioItem;


                }
            }


            return null;
        }
        public FuncionarioItem GetFuncFromList(int index)
        {
            FuncionarioItem currentFunc = FuncionarioCollection[index];

            return currentFunc;

        }











    }
}
