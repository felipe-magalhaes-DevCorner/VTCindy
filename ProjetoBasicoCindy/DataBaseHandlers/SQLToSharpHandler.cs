using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;

namespace ProjetoBasicoCindy
{
    public class SqlToSharpHandler
    {
        #region FUNCIONARIO HANDLERS
        /// <summary>
        /// CONVERT FUNCIONARIO SQL INFORMATION TO FUNCIONARIOITEM
        /// 
        /// SEM INFORMACOES DE ONIBUS
        /// </summary>
        /// <param name="_dt"></param>
        /// <returns></returns>
        public FuncionarioItem ConvertoFromSqlTo_1_FuncionarioItem(DataTable dt)
        {
            List<FuncionarioItem> listFUncionarios = new List<FuncionarioItem>();
            int aux = 0;
            FuncionarioItem funcionario = null;
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow rows in dt.Rows)
                {

                    Image picture = null;
                    //helper less conversions
                    int row = 0;
                    //matricula
                    int matricula = Convert.ToInt32(dt.Rows[row][0]);
                    if (matricula >= aux)
                    {
                        aux = matricula;
                    }
                    //deal if date is a picture
                    if (Convert.IsDBNull(dt.Rows[row][1]) == false)
                    {
                        Byte[] data = new Byte[0];
                        data = (Byte[])(dt.Rows[row][1]);
                        MemoryStream mem = new MemoryStream(data);
                        picture = Image.FromStream(mem);
                    }
                    //nome.... etc
                    string nome = dt.Rows[row][2].ToString();
                    string identidade = dt.Rows[row][3].ToString();
                    string cpf = dt.Rows[row][4].ToString();
                    DateTime dn = Convert.ToDateTime(dt.Rows[row][5]);
                    string sexo = dt.Rows[row][6].ToString();
                    string rua = dt.Rows[row][7].ToString();
                    string numero = dt.Rows[row][8].ToString();
                    string bairro = dt.Rows[row][9].ToString();
                    string cidade = dt.Rows[row][10].ToString();
                    string estado = dt.Rows[row][11].ToString();
                    string complemento = dt.Rows[row][12].ToString();
                    string cep = dt.Rows[row][13].ToString();
                    string observacao = dt.Rows[row][14].ToString();
                    bool inativo = Convert.ToBoolean(dt.Rows[row][15]);
                    string telefone = dt.Rows[row][16].ToString();
                    DateTime admissao = Convert.ToDateTime(dt.Rows[row][17]);
                    CultureInfo cult = new CultureInfo("pt-BR");
                    DateTime inativacao;
                    if (Convert.IsDBNull(dt.Rows[row][18]) == false)
                    {
                         inativacao = Convert.ToDateTime(dt.Rows[row][18], cult);
                    }
                    else
                    {
                         inativacao = Convert.ToDateTime( "01/01/1900", cult);
                    }
                    
                    var dataBaseHandler = new DataBaseHandler();
                    var sQlDataHandler = new SqlToSharpHandler();

                    //Get func information bus
                    OnibusItemCollection funcListOnibus = new OnibusItemCollection();
                    funcListOnibus.SetList(sQlDataHandler.ConvertSQlToBusCollectionItem(dataBaseHandler.GetBus(matricula)));

                    //get information about Vaccine
                    Vacina.FuncionarioVaccinaColletion funcVaccineList = new Vacina.FuncionarioVaccinaColletion();
                    funcVaccineList.SetList(sQlDataHandler.ConvertSqlVaccineToColletion(dataBaseHandler.GetVacinas(matricula)));

                    //get func information about ferias
                    Ferias.FeriasColletionItem listFerias = new Ferias.FeriasColletionItem();
                    listFerias.SetList(sQlDataHandler.ConvertSqLtoFeriasItem(dataBaseHandler.GetFerias(matricula)));

                    //get information about exames

                    Exames.Data.ExameItemColletion collectionExams = new Exames.Data.ExameItemColletion();

                    Exames.Data.ExameItemColletion colletion = sQlDataHandler.ConvertSqlExamToItem(dataBaseHandler.GetExames(matricula));
                    //CollectionExams.SetList(SQlDataHandler.ConvertSqlExamToItem(DataBaseHandler.GetExames(matricula)));




                    //GENERATES FUNCIONARIO ITEM WITH ALL INFO COLLECTED                
                    funcionario = new FuncionarioItem(matricula, picture, nome, cpf, identidade, sexo, dn, rua, numero, complemento, bairro, observacao, cidade, estado, cep, telefone, inativo, admissao, inativacao, null, funcListOnibus, funcVaccineList, listFerias, colletion);
                    var funcionarioSelected = new FuncionarioItemEdit();
                    funcionarioSelected.SetFuncionarioEdit(funcionario);
                    row++;
                }

            }

            return funcionario;
        }

        #endregion

        #region BUS HANDLERS
        public List<OnibusItem> ConvertSQlToBusCollectionItem(DataTable dt)
        {

            int row = 0;
            var listOnibus = new List<OnibusItem>();
            foreach (DataRow item in dt.Rows)
            {

                var onibusItem = new OnibusItem(Convert.ToInt32(dt.Rows[row][0].ToString()), dt.Rows[row][1].ToString(), dt.Rows[row][2].ToString(), Convert.ToDouble(dt.Rows[row][3], new CultureInfo("en-US")));
                listOnibus.Add(onibusItem);
            }

            return listOnibus;

        }
        #endregion

        #region Ferias Handlers

        public List<Ferias.FeriasItem> ConvertSqLtoFeriasItem (DataTable dt)
        {
            var listFerias = new List<Ferias.FeriasItem>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ferias.FeriasItem feriasItem = new Ferias.FeriasItem(Convert.ToDateTime(dt.Rows[i][1].ToString()), Convert.ToDateTime(dt.Rows[i][2].ToString()));
                listFerias.Add(feriasItem);

            }

            return listFerias;
        }
        #endregion

        #region Documento Handlers
        public List<DocumentosPictureItem> ConvertSqlToDocCollectionItem(DataTable dt)
        {

            int row = 0;
            var listDoc = new List<DocumentosPictureItem>();
            foreach (DataRow item in dt.Rows)
            {
                Image picture = null;

                if (Convert.IsDBNull(dt.Rows[row][0]) == false)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dt.Rows[row][0]);
                    MemoryStream mem = new MemoryStream(data);
                    picture = Image.FromStream(mem);
                }
                int pagina = Convert.ToInt32(dt.Rows[row][1]);
                int tipoDoc = Convert.ToInt32(dt.Rows[row][2]);






                var docItem = new DocumentosPictureItem(picture, tipoDoc, pagina);
                listDoc.Add(docItem);
            }

            return listDoc;

        }








        #endregion

        #region Vaccine Handlers
        public List<Vacina.Vacina> ConvertSqlVaccineToColletion(DataTable dt)
        {
            var listVaccine = new List<Vacina.Vacina>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Vacina.VacinaInfo information = new Vacina.VacinaInfo(Convert.ToDateTime(dt.Rows[i][4].ToString()), dt.Rows[i][3].ToString(), dt.Rows[i][2].ToString());
                Vacina.Vacina vacina = new Vacina.Vacina(dt.Rows[i][0].ToString(), information, (Convert.ToInt32(dt.Rows[i][1].ToString())));
                listVaccine.Add(vacina);

            }
            
           

            return listVaccine;
        }

        #endregion

        #region Exames handlers
        public Exames.Data.ExameItemColletion ConvertSqlExamToItem(DataTable dt)
        {
            //variaveis
            
            Exames.Data.ExameItemColletion colecaoFuncionario = new Exames.Data.ExameItemColletion();
            
            Exames.Data.ExamList colecaoTipo = new Exames.Data.ExamList();
            List<Exames.Data.ExamList> listAso;
            string auxNomeExame = null;
            string tipagem = null;
            
            var exame = new Exames.Data.Examitem();
            //run tru Datatable rows


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //read exam being used right now
                var currentExamName = dt.Rows[i]["descricaoexame"].ToString();
                
                //case first run
                //case same exam name
                if (auxNomeExame == null || auxNomeExame == currentExamName)
                {           
                    //records in aux variable
                    auxNomeExame = currentExamName;
                    //deal with exam item
                    exame.Nome = auxNomeExame;
                    exame.Nome = dt.Rows[i]["descricaoexame"].ToString();
                    
                    exame.DataExame.Add(Convert.ToDateTime(dt.Rows[i]["Data"]));
                    exame.Protocolo.Add(dt.Rows[i]["protocolo"].ToString());

                    //tells tipagem list its name
                    //for current exam

                    tipagem = dt.Rows[i ]["tipagem"].ToString();

                }
                //exam is not the same as before
                else
                {
                    //store exams in list
                    //after exam change
                    if (tipagem == dt.Rows[i]["tipagem"].ToString())
                    {                    
                        colecaoTipo.ExameColletion.Add(exame);
                    }
                    else
                    {
                        colecaoTipo.ExameColletion.Add(exame);
                        colecaoTipo.Tipagem = tipagem; ;

                        DealWithTipagem(colecaoFuncionario, colecaoTipo);
                        //create new class for new tipagem
                        colecaoTipo = new Exames.Data.ExamList();
                        tipagem = dt.Rows[i]["tipagem"].ToString();
                        colecaoTipo.Tipagem = tipagem;

                    }

                    //---------------------START DEALING WITH NEW EXAM---------------------
                    exame = new Exames.Data.Examitem();
                    auxNomeExame = currentExamName;
                    //deal with exam item
                    exame.Nome = auxNomeExame;
                    exame.Nome = dt.Rows[i]["descricaoexame"].ToString();
                    exame.DataExame.Add(Convert.ToDateTime(dt.Rows[i]["Data"]));
                    exame.Protocolo.Add(dt.Rows[i]["protocolo"].ToString());


                    if (dt.Rows.Count - 1 == i)
                    {
                        colecaoTipo.ExameColletion.Add(exame);
                        DealWithTipagem(colecaoFuncionario, colecaoTipo);
                    }
                }
            }
            return colecaoFuncionario;
        }

        private static void DealWithTipagem(Exames.Data.ExameItemColletion colecaoFuncionario, Exames.Data.ExamList colecaoTipo)
        {
            if (colecaoTipo.Tipagem == "Exame")
            {
                colecaoFuncionario.Exames.Add(colecaoTipo);
            }
            else if (colecaoTipo.Tipagem == "Extra")
            {
                colecaoFuncionario.Exames.Add(colecaoTipo);
            }
            else
            {
                colecaoFuncionario.Exames.Add(colecaoTipo);
            }
        }
        #endregion

        #region Save Handlers

        public void SaveToSql(FuncionarioItem funcionario)
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
