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
                _identidade = funcionarioInfo[1].ToString(),
                _name = funcionarioInfo[2].ToString(),
                _cpf = funcionarioInfo[3].ToString(),                
                _sexo = funcionarioInfo[4].ToString(),
                _dataNascimento = Convert.ToDateTime(funcionarioInfo[5]),
                _rua = funcionarioInfo[6].ToString(),
                _numero = funcionarioInfo[7].ToString(),
                _complemento = funcionarioInfo[8].ToString(),
                _bairro = funcionarioInfo[9].ToString(),
                _observacao = funcionarioInfo[10].ToString(),
                _cidade = funcionarioInfo[11].ToString(),
                _estado = funcionarioInfo[12].ToString(),
                _cep = funcionarioInfo[13].ToString()
            };

            _lista.Add(Aux);
            return _lista;










        }

    }
}
