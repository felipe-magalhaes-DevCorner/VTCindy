
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public class DataBaseHandler
    {

        #region preview SQL
        public DataTable PreviewGetFuncionariosTolist()
        {
            DataTable dt;

            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = "Select funcionario.idfuncionario, funcionario.nome from funcionario";
                db.SqlQuery(query);
                db.QueryRun();
                dt = db.QueryDT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro" + ex));
                throw;
            }
            finally
            {
                db.closeConnection();
            }

            return dt;
        }
        #endregion


        #region sql funcionario
        /// <summary>
        /// PEGA INFORMACOES DO FUNCIONARIO
        /// </summary>
        /// <returns>RETORNA DATATABLE COMPLETA FUNCIONARIOS</returns>
        public DataTable GetFuncionariosToList()
        {
            DataTable dt;

            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = "Select * from funcionario";
                db.SqlQuery(query);
                db.QueryRun();
                dt = db.QueryDT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro" + ex));
                throw;
            }
            finally
            {
                db.closeConnection();
            }

            return dt;
        }
        public DataTable GetFuncionariosInfo(string idfuncionario)
        {
            DataTable dt;

            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = "Select * from funcionario where funcionario.idfuncionario = '" + idfuncionario + "'";
                db.SqlQuery(query);
                db.QueryRun();
                dt = db.QueryDT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro" + ex));
                throw;
            }
            finally
            {
                db.closeConnection();
            }

            return dt;
        }
        #endregion


        #region sql onibus

        public DataTable GetBus(int matricula)
        {
            DataTable dtb;

            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format(
                    "select onibus.idonibus, RTRIM(onibus.linha) AS LINHA, RTRIM(onibus.cartao) AS CARTAO, RTRIM(onibus.preco) AS PRECO " +
                    "from onibus " +
                    "inner join onibuscliente on onibuscliente.idonibus = onibus.idonibus " +
                    "inner join funcionario on funcionario.idfuncionario = onibuscliente.idcliente " +
                     "where funcionario.idfuncionario = '{0}'", matricula);

                db2.SqlQuery(query);
                db2.QueryRun();
                dtb = db2.QueryDT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro" + ex));
                throw;
            }
            finally
            {
                db2.closeConnection();
            }
            return dtb;

        }
        public void AddBus(string matricula, string idlinha, string linha, string cartao, string descricao)
        {
            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                string query = "insert into onibuscliente values('" + idlinha + "', '" + matricula + "' ";
                db.SqlConnection();
                db.SqlQuery(query);
                db.QueryRun();
                query = "insert into onibus values('" + idlinha + "', '" + linha + "','" + cartao + "', '" + descricao + "')";
                db.SqlQuery(query);
                db.QueryRun();


            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro" + ex));
                throw;
            }
            finally
            {
                db.closeConnection();
            }


        }

        #endregion

        #region SQL Ferias

        /// <summary>
        /// busca no bando de dados informacoes sobre ferias apra devido funcionario. BASEADO EM NUMERO DE IDFUNCIONARIO.        
        /// </summary>
        /// <param name="idfuncionario"></param>
        public DataTable GetFerias(int idfuncionario)
        {
            DataTable dt;
            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = string.Format(
                    "select ferias.idferias, ferias.datainicio, ferias.datafim from ferias " +
                    "inner join func_ferias on (func_ferias.idferias = ferias.idferias) " +
                    "inner join funcionario on (funcionario.idfuncionario = func_ferias.idfunc) " +
                    "where idfuncionario = '{0}'", idfuncionario);
                Clipboard.SetText(query);
                db.SqlQuery(query);
                db.QueryRun();
                dt = db.QueryDT();

            }
            finally
            {
                db.closeConnection();
            }




            return dt;



        }


        #endregion

        #region SQL Vacine
        public DataTable GetVacinas(int idfuncionario)
        {
            DataTable dt;
            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format(
                    "select vacina.descricao, vacina_dose.dosenumero, vacina_dose.unidade, vacina_dose.lote," +
                    "vacina_funcionario.data, vacina_funcionario.dataexpiracao, vacina_funcionario.proximadose from vacina " +
                    "INNER JOIN vacina_funcionario on (vacina_funcionario.idvacina = vacina.id) " +
                    "inner join vacina_dose on (vacina_dose.idvacina_funcionario = vacina_funcionario.idvacina) " +
                    "inner join funcionario on (funcionario.idfuncionario = vacina_funcionario.idfuncionario) " +
                    "where funcionario.idfuncionario = '{0}' order by 1, 2", idfuncionario);
                db2.SqlQuery(query);
                db2.QueryRun();
                dt = db2.QueryDT();

            }
            finally
            {
                db2.closeConnection();
            }




            return dt;



        }
        #endregion

        #region SQL exames
        public DataTable GetExames(int idfuncionario)
        {
            DataTable dt;
            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query =
                    "SELECT  func_exames.idfunc, exames.descricaoexame, exame_protocolo.protocolo, exame_protocolo.data," +
                    " exames.tipagem FROM exames" +
                    " inner join exame_protocolo on(exame_protocolo.id_exame = exames.idexame)" +
                    " inner join func_exames on(func_exames.idprotocoloexame = exame_protocolo.id_protocolo_exame)" +
                    $" where func_exames.idfunc = '{idfuncionario}'" + " order by 5 , 2 , 4";
                Clipboard.SetText(query);
                db.SqlQuery(query);
                db.QueryRun();
                dt = db.QueryDT();

            }
            catch (Exception)
            {

                throw new Exception("Erro ao puxar sql exames");
            }
            finally
            {
                db.closeConnection();
            }
            return dt;
        }
        #endregion

        #region SQL Documentos
        public DataTable GetDocuments(int matricula)
        {
            DataTable dt;
            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format(
                    "select documento.image, documento.pagina, tipo_documento.id " +
                    "from documento " +
                    "inner join documento_funcionario on documento_funcionario.iddoc = documento.ID " +
                    "inner join tipo_documento on tipo_documento.id = documento_funcionario.tipo " +
                     "where documento_funcionario.idfunc = '{0}'", matricula);

                db2.SqlQuery(query);
                db2.QueryRun();
                dt = db2.QueryDT();

            }
            finally
            {
                db2.closeConnection();
            }




            return dt;
        }
        #endregion

        #region EditHandler
        /// <summary>
        /// compares funcionario items for change
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>returns true if anything changed, or false if nothing changed</returns>
        public bool CompareFuncionario(FuncionarioItem funcionario)
        {

            var objFuncCollection = new FuncionarioItemCollection();

            List<FuncionarioItem> mainList = objFuncCollection.GetFuncionariosList();
            foreach (FuncionarioItem func in mainList)
            {
                //searches funcionario collection for funcionario currently being edited.
                if (func.IdFuncionario == funcionario.IdFuncionario)
                {
                    //if found, compare all fields, text datetime and bool.
                    //does not check documentos or onibus
                    if ((func.Name == funcionario.Name) & (func.FuncPic == funcionario.FuncPic) & (func.Cpf == funcionario.Cpf) & (func.Identidade == funcionario.Identidade) & (func.Sexo == funcionario.Sexo) & (func.DataNascimento == funcionario.DataNascimento) & (func.Rua == funcionario.Rua) & (func.Numero == funcionario.Numero) & (func.Complemento == funcionario.Complemento) & (func.Bairro == funcionario.Bairro) & (func.Observacao == funcionario.Observacao) & (func.Cidade == funcionario.Cidade) & (func.Estado == funcionario.Estado) & (func.Cep == funcionario.Cep) & (func.Telefone == funcionario.Telefone) & (func.Inativo == funcionario.Inativo) & (CheckBus(func.Onibus, funcionario.Onibus)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
                else
                {
                    return false;
                }
            }
            //for c# to stop complaining about return parameter.
            return false;
        }
        /// <summary>
        /// compares onibus item for changes on onibus collection
        /// </summary>
        /// <param name="buscollectionOrigem"></param>
        /// <param name="buscollectionEdit"></param>
        /// <returns>returns true if changed, or false if nothing changed.</returns>
        private bool CheckBus(OnibusItemCollection buscollectionOrigem, OnibusItemCollection buscollectionEdit)
        {
            List<OnibusItem> originalBus = buscollectionOrigem.GetFuncionarioOnibusCollection();
            List<OnibusItem> editBus = buscollectionEdit.GetFuncionarioOnibusCollection();
            if (originalBus.Count() == editBus.Count())
            {
                //count elements is the same
#pragma warning disable 162
                for (int i = 0; i < originalBus.Count(); i++)
#pragma warning restore 162
                {
                    //check all onibus items in collection
                    if ((originalBus[i].Linha == editBus[i].Linha) & originalBus[i].Preco == editBus[i].Preco & (originalBus[i].Cartao == editBus[i].Cartao))
                    {
                        //passed testes, all busses linhas and prices are the same
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            //count is different
            else
            {
                return false;
            }
            return false;
        }



        #endregion


    }
}
