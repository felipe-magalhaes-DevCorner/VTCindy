using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class SQLToSharpHandler
    {
        #region FUNCIONARIO HANDLERS
        /// <summary>
        /// CONVERT FUNCIONARIO SQL INFORMATION TO FUNCIONARIOITEM
        /// 
        /// SEM INFORMACOES DE ONIBUS
        /// </summary>
        /// <param name="_dt"></param>
        /// <returns></returns>
        public FuncionarioItem ConvertoFromSqlTo_1_FuncionarioItem(DataTable _dt)
        {
            List<FuncionarioItem> listFUncionarios = new List<FuncionarioItem>();
            int aux = 0;
            FuncionarioItem funcionario = null;
            if (_dt.Rows.Count == 1)
            {
                foreach (DataRow rows in _dt.Rows)
                {

                    Image picture = null;
                    //helper less conversions
                    int row = 0;
                    //matricula
                    int matricula = Convert.ToInt32(_dt.Rows[row][0]);
                    if (matricula >= aux)
                    {
                        aux = matricula;
                    }
                    //deal if date is a picture
                    if (Convert.IsDBNull(_dt.Rows[row][1]) == false)
                    {
                        Byte[] data = new Byte[0];
                        data = (Byte[])(_dt.Rows[row][1]);
                        MemoryStream mem = new MemoryStream(data);
                        picture = Image.FromStream(mem);
                    }
                    //nome.... etc
                    string nome = _dt.Rows[row][2].ToString();
                    string identidade = _dt.Rows[row][3].ToString();
                    string cpf = _dt.Rows[row][4].ToString();
                    DateTime DN = Convert.ToDateTime(_dt.Rows[row][5]);
                    string sexo = _dt.Rows[row][6].ToString();
                    string rua = _dt.Rows[row][7].ToString();
                    string numero = _dt.Rows[row][8].ToString();
                    string bairro = _dt.Rows[row][9].ToString();
                    string cidade = _dt.Rows[row][10].ToString();
                    string estado = _dt.Rows[row][11].ToString();
                    string complemento = _dt.Rows[row][12].ToString();
                    string cep = _dt.Rows[row][13].ToString();
                    string observacao = _dt.Rows[row][14].ToString();
                    bool inativo = Convert.ToBoolean(_dt.Rows[row][15]);
                    string telefone = _dt.Rows[row][16].ToString();
                    var SQLOnibusColletion = new DataBaseHandler();
                    var SQlDataHandler = new SQLToSharpHandler();
                    OnibusItemCollection funcList = new OnibusItemCollection();
                    funcList.SetList(SQlDataHandler.ConvertSQlToBusCollectionItem(SQLOnibusColletion.GetBus(matricula)));
                        


                    //GENERATES FUNCIONARIO ITEM WITH ALL INFO COLLECTED                
                    funcionario = new FuncionarioItem(matricula, picture, nome, cpf, identidade, sexo, DN, rua, numero, complemento, bairro, observacao, cidade, estado, cep, telefone, inativo, null, funcList);
                    row++;
                }

            }

            return funcionario;
        }

        #endregion

        #region BUS HANDLERS
        public List<OnibusItem> ConvertSQlToBusCollectionItem(DataTable _dt)
        {

            int row = 0;
            var ListOnibus = new List<OnibusItem>();
            foreach (DataRow item in _dt.Rows)
            {
                
                var onibusItem = new OnibusItem(Convert.ToInt32( _dt.Rows[row][0].ToString()), _dt.Rows[row][1].ToString(), _dt.Rows[row][2].ToString(), Convert.ToDouble( _dt.Rows[row][3], new CultureInfo("en-US")));
                ListOnibus.Add(onibusItem);
            }

            return ListOnibus;

        }
        #endregion


    }
}
