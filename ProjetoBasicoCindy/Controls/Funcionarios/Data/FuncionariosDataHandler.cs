using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class FuncionariosDataHandler
    {
        public static List<FuncionarioItem> StoreInformation (List<string> funcionarioInfo, List<FuncionarioItem> _lista)
        {

            var Aux = new FuncionarioItem
            {
                _idFuncionario = Convert.ToInt32(funcionarioInfo[0]),
                _name = funcionarioInfo[1].ToString(),
                _cpf = funcionarioInfo[2].ToString(),
                _sexo = funcionarioInfo[3].ToString(),
                _dataNascimento = Convert.ToDateTime(funcionarioInfo[4]),
                _rua = funcionarioInfo[5].ToString(),
                _numero = funcionarioInfo[6].ToString(),
                _complemento = funcionarioInfo[7].ToString(),
                _descricao = funcionarioInfo[8].ToString(),
                _cidade = funcionarioInfo[9].ToString(),
                _estado = funcionarioInfo[10].ToString(),
                _cep = funcionarioInfo[11].ToString()
            };

            _lista.Add(Aux);
            return _lista;










        }

    }
}
