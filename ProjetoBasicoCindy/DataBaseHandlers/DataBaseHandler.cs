
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public class DataBaseHandler
    {

        #region preview SQL
        public DataTable PreviewGetFuncionariosTolist()
        {
            DataTable _dt;

            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = "Select funcionario.idfuncionario, funcionario.nome from funcionario";
                db.SqlQuery(query);
                db.QueryRun();
                _dt = db.QueryDT();
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

            return _dt;
        }
        #endregion


        #region sql funcionario
        /// <summary>
        /// PEGA INFORMACOES DO FUNCIONARIO
        /// </summary>
        /// <returns>RETORNA DATATABLE COMPLETA FUNCIONARIOS</returns>
        public DataTable GetFuncionariosToList()
        {
            DataTable _dt;

            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = "Select * from funcionario";
                db.SqlQuery(query);
                db.QueryRun();
                _dt = db.QueryDT();
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

            return _dt;
        }
        public DataTable GetFuncionariosInfo(string _idfuncionario)
        {
            DataTable _dt;

            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = "Select * from funcionario where funcionario.idfuncionario = '" + _idfuncionario + "'";
                db.SqlQuery(query);
                db.QueryRun();
                _dt = db.QueryDT();
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

            return _dt;
        }
        #endregion


        #region sql onibus

        public DataTable GetBus(int _matricula)
        {
            DataTable _dtb;

            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format(
                    "select onibus.idonibus, RTRIM(onibus.linha) AS LINHA, RTRIM(onibus.cartao) AS CARTAO, RTRIM(onibus.preco) AS PRECO " +
                    "from onibus " +
                    "inner join onibuscliente on onibuscliente.idonibus = onibus.idonibus " +
                    "inner join funcionario on funcionario.idfuncionario = onibuscliente.idcliente " +
                     "where funcionario.idfuncionario = '{0}'", _matricula);

                db2.SqlQuery(query);
                db2.QueryRun();
                _dtb = db2.QueryDT();
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
            return _dtb;

        }
        public void AddBus(string _matricula, string idlinha, string linha, string cartao, string descricao)
        {
            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                string query = "insert into onibuscliente values('" + idlinha + "', '" + _matricula + "' ";
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
        /// <param name="_idfuncionario"></param>
        public DataTable GetFerias(int _idfuncionario)
        {
            var _dt = new DataTable();
            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format(
                    "select ferias.idferias, ferias.datainicio, ferias.datafim from ferias "+
                    "inner join func_ferias on (func_ferias.idferias = ferias.idferias) " + 
                    "inner join funcionario on (funcionario.idfuncionario = func_ferias.idfunc) " + 
                    "where idfuncionario = '{0}'", _idfuncionario);

                db2.SqlQuery(query);
                db2.QueryRun();
                _dt = db2.QueryDT();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db2.closeConnection();
            }




            return _dt;



        }


        #endregion

        #region SQL Vacine
        public DataTable GetVacinas(int _idfuncionario)
        {
            var _dt = new DataTable();
            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format(
                    "select vacina.descricao, vacina_dose.dosenumero, vacina_dose.unidade, vacina_dose.lote," +
                    "vacina_funcionario.data, vacina_funcionario.dataexpiracao, vacina_funcionario.proximadose from vacina " +
                    "INNER JOIN vacina_funcionario on (vacina_funcionario.idvacina = vacina.id) " +
                    "inner join vacina_dose on (vacina_dose.idvacina_funcionario = vacina_funcionario.idfuncionario) " +
                    "inner join funcionario on (funcionario.idfuncionario = vacina_funcionario.idfuncionario) " +
                    "where funcionario.idfuncionario = '{0}' order by 1, 2", _idfuncionario);
                db2.SqlQuery(query);
                db2.QueryRun();
                _dt = db2.QueryDT();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db2.closeConnection();
            }




            return _dt;



        }
        #endregion

        #region SQL Documentos
        public DataTable GetDocuments(int _matricula)
        {
            var _dt = new DataTable();
            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format(
                    "select documento.image, documento.pagina, tipo_documento.id " +
                    "from documento " +
                    "inner join documento_funcionario on documento_funcionario.iddoc = documento.ID " +
                    "inner join tipo_documento on tipo_documento.id = documento_funcionario.tipo " +
                     "where documento_funcionario.idfunc = '{0}'", _matricula);

                db2.SqlQuery(query);
                db2.QueryRun();
                _dt = db2.QueryDT();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db2.closeConnection();
            }




            return _dt;
        }
        #endregion

        #region EditHandler
        /// <summary>
        /// compares funcionario items for change
        /// </summary>
        /// <param name="_funcionario"></param>
        /// <returns>returns true if anything changed, or false if nothing changed</returns>
        public bool CompareFuncionario(FuncionarioItem _funcionario)
        {
            List<string> changedValues = new List<string>();
            var objFuncCollection = new FuncionarioItemCollection();

            List<FuncionarioItem> mainList = objFuncCollection.GetFuncionariosList();
            foreach (FuncionarioItem func in mainList)
            {
                //searches funcionario collection for funcionario currently being edited.
                if (func._idFuncionario == _funcionario._idFuncionario)
                {
                    //if found, compare all fields, text datetime and bool.
                    //does not check documentos or onibus
                    if ((func._name == _funcionario._name) & (func._funcPic == _funcionario._funcPic) & (func._cpf == _funcionario._cpf) & (func._identidade == _funcionario._identidade) & (func._sexo == _funcionario._sexo) & (func._dataNascimento == _funcionario._dataNascimento) & (func._rua == _funcionario._rua) & (func._numero == _funcionario._numero) & (func._complemento == _funcionario._complemento) & (func._bairro == _funcionario._bairro) & (func._observacao == _funcionario._observacao) & (func._cidade == _funcionario._cidade) & (func._estado == _funcionario._estado) & (func._cep == _funcionario._cep) & (func._telefone == _funcionario._telefone) & (func._inativo == _funcionario._inativo) & (CheckBus(func._onibus, _funcionario._onibus)))
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
        /// <param name="_buscollectionOrigem"></param>
        /// <param name="_buscollectionEdit"></param>
        /// <returns>returns true if changed, or false if nothing changed.</returns>
        private bool CheckBus (OnibusItemCollection _buscollectionOrigem, OnibusItemCollection _buscollectionEdit)
        {
            List<OnibusItem> originalBus = _buscollectionOrigem.GetFuncionarioOnibusCollection();
            List<OnibusItem> EditBus = _buscollectionEdit.GetFuncionarioOnibusCollection();
            if (originalBus.Count() == EditBus.Count())
            {
                //count elements is the same
                for (int i = 0; i < originalBus.Count(); i++)
                {
                    //check all onibusitems in collection
                    if ((originalBus[i]._linha == EditBus[i]._linha) & (originalBus[i]._preco == EditBus[i]._preco) & (originalBus[i]._cartao == EditBus[i]._cartao))
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
