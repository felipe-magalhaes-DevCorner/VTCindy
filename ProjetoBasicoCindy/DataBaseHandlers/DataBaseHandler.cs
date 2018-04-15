using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class DataBaseHandler
    {

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
        public DataTable GetBus(string _matricula)
        {
            DataTable _dtb;

            var db2 = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db2.SqlConnection();
                var query = string.Format("Select onibus.numero, onibus.preco from onibus where onibus.matricula = '{0}'", _matricula);
                db2.SqlQuery(query);
                db2.QueryRun();
                _dtb = db2.QueryDT();





            }
            catch (Exception ex)
            {
                //MessageBox.Show(string.Format("Erro" + ex));
                throw;
            }
            finally
            {
                db2.closeConnection();
            }
            return _dtb;

        }
    }
}
