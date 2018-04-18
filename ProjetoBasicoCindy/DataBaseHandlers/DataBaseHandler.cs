
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
        public DataTable GetFuncionariosList()
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
                //MessageBox.Show(string.Format("Erro" + ex));
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
        public DataTable GetBus(string _matricula)
        {
            DataTable _dtb;

            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format(
                    "select RTRIM(onibus.linha) AS LINHA, RTRIM(onibus.cartao) AS CARTAO, RTRIM(onibus.preco) AS PRECO " +
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
        /// <summary>
        /// PEGA TODAS AS INFORMACOES DE ONIBUS DA MATRICULA REQUERIDA
        /// </summary>
        /// <param name="_matricula"></param>
        /// <returns>DATATABLE COM OS ONIBUS, CARTAO, E PRECOS DO MESMO</returns>

    }
}
