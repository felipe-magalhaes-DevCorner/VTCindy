using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class FuncionarioItemPreview
    {
        public int _idfuncionario { get; set; }
        public string _name { get; set; }
        public FuncionarioItemPreview(int idfuncionario, string name)
        {
            _idfuncionario = idfuncionario;
            _name = name;
        }


        public void GetPreview(FuncionarioItem _funcionario)
        {
            string[] PreviewArray = { _funcionario._idFuncionario.ToString(), _funcionario._name };
        }

    }



}
