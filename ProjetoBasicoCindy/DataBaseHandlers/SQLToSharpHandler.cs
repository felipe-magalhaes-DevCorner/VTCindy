using ProjetoBasicoCindy;
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
                    DateTime admissao = Convert.ToDateTime(_dt.Rows[row][17]);
                    CultureInfo cult = new CultureInfo("pt-BR");
                    DateTime inativacao;
                    if (Convert.IsDBNull(_dt.Rows[row][18]) == false)
                    {
                         inativacao = Convert.ToDateTime(_dt.Rows[row][18], cult);
                    }
                    else
                    {
                         inativacao = Convert.ToDateTime( "01/01/1900", cult);
                    }
                    
                    var DataBaseHandler = new DataBaseHandler();
                    var SQlDataHandler = new SQLToSharpHandler();

                    //Get func information bus
                    OnibusItemCollection funcListOnibus = new OnibusItemCollection();
                    funcListOnibus.SetList(SQlDataHandler.ConvertSQlToBusCollectionItem(DataBaseHandler.GetBus(matricula)));

                    //get information about Vaccine

                    Vacina.FuncionarioVaccinaColletion funcVaccineList = new Vacina.FuncionarioVaccinaColletion();
                    funcVaccineList.SetList(SQlDataHandler.ConvertSQLVaccineToColletion(DataBaseHandler.GetVacinas(matricula)));






                    //get func information about ferias
                    Ferias.FeriasColletionItem listFerias = new Ferias.FeriasColletionItem();
                    listFerias.SetList(SQlDataHandler.ConvertSQLtoFeriasItem(DataBaseHandler.GetFerias(matricula)));




                    //GENERATES FUNCIONARIO ITEM WITH ALL INFO COLLECTED                
                    funcionario = new FuncionarioItem(matricula, picture, nome, cpf, identidade, sexo, DN, rua, numero, complemento, bairro, observacao, cidade, estado, cep, telefone, inativo, admissao, inativacao, null, funcListOnibus, funcVaccineList, listFerias);
                    var FuncionarioSelected = new FuncionarioItemEdit();
                    FuncionarioSelected.SetFuncionarioEdit(funcionario);
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

                var onibusItem = new OnibusItem(Convert.ToInt32(_dt.Rows[row][0].ToString()), _dt.Rows[row][1].ToString(), _dt.Rows[row][2].ToString(), Convert.ToDouble(_dt.Rows[row][3], new CultureInfo("en-US")));
                ListOnibus.Add(onibusItem);
            }

            return ListOnibus;

        }
        #endregion

        #region Ferias Handlers

        public List<Ferias.FeriasItem> ConvertSQLtoFeriasItem (DataTable _dt)
        {
            var ListFerias = new List<Ferias.FeriasItem>();
            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                Ferias.FeriasItem feriasItem = new Ferias.FeriasItem(Convert.ToDateTime(_dt.Rows[i][1].ToString()), Convert.ToDateTime(_dt.Rows[i][2].ToString()));
                ListFerias.Add(feriasItem);

            }
            foreach (DataRow item in _dt.Rows)
            {

                
            }
            return ListFerias;
        }
        #endregion
        #region Documento Handlers
        public List<DocumentosPictureItem> ConvertSQlToDOCCollectionItem(DataTable _dt)
        {

            int row = 0;
            var listDoc = new List<DocumentosPictureItem>();
            foreach (DataRow item in _dt.Rows)
            {
                Image picture = null;

                if (Convert.IsDBNull(_dt.Rows[row][0]) == false)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(_dt.Rows[row][0]);
                    MemoryStream mem = new MemoryStream(data);
                    picture = Image.FromStream(mem);
                }
                int pagina = Convert.ToInt32(_dt.Rows[row][1]);
                int tipoDoc = Convert.ToInt32(_dt.Rows[row][2]);






                var DocItem = new DocumentosPictureItem(picture, tipoDoc, pagina);
                listDoc.Add(DocItem);
            }

            return listDoc;

        }








        #endregion
        #region Vaccine Handlers
        public List<Vacina.Vacina> ConvertSQLVaccineToColletion(DataTable _dt)
        {
            var ListVaccine = new List<Vacina.Vacina>();
            for (int i = 0; i < _dt.Rows.Count; i++)
            {

                Vacina.VacinaInfo information = new Vacina.VacinaInfo(Convert.ToDateTime(_dt.Rows[i][4].ToString()), _dt.Rows[i][3].ToString(), _dt.Rows[i][2].ToString());
                Vacina.Vacina vacina = new Vacina.Vacina(_dt.Rows[i][0].ToString(), information, (Convert.ToInt32(_dt.Rows[i][1].ToString())));
                ListVaccine.Add(vacina);

            }
            
           

            return ListVaccine;
        }

        #endregion

        #region Save Handlers

        public void SaveToSQL(FuncionarioItem _funcionario)
        {
            //instance connection class
            ConnectionClass_SQL.ConnectionClass db = new ConnectionClass_SQL.ConnectionClass();
            //prepare query for sql iinjection
        }




        #endregion

        #region equality controllers

    

        #endregion



    }
}
