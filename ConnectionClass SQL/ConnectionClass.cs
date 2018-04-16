using System;

using System.Data;
using System.Data.SqlClient;


namespace ConnectionClass_SQL
{
    public class ConnectionClass
    {
        // We use these three Sql objects:
        private SqlConnection _conn;
        private SqlCommand _cmd;
        private SqlDataReader _datareader;
        private SqlDataAdapter _datadapter;
        private DataTable _dt;
        public void SqlConnection()
        {
            /////------------------------- AKI DIZEMOS AONDE ESTA O SQL-------------------------------


            //_conn = new SqlConnection("Data Source=gmn-bancodados;Initial Catalog=valetransporte;Persist Security Info=True;User ID=sa;Password=n3fr0d@t@");
            _conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VtCindy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            /////------------------------- ABRO A CONEXAO-------------------------------
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }


        }
        public int SqlQuerywithParameters(string pQueryText, string[,] parameters)
        ////
        {

            /////------------------------- DOU COLAR NA QUERO NO SQL E DIGO AONDE COLAR-------------------------------
            _cmd = new SqlCommand(pQueryText, _conn)
            {
                CommandType = CommandType.Text
            };
            //parametros
            //array multidimencional
            //parametro + valor parametro
            //AddWithValue(array[i,0], [i,1]);
            for (int i = 0; i < parameters.GetLength(0); i++)
            {
                _cmd.Parameters.AddWithValue(parameters[i, 0], parameters[i, 1]);

            }
            var count = Convert.ToInt32(_cmd.ExecuteScalar());
            return count;


        }
        public void SqlQuery(string pQueryText)
        {
            /////------------------------- DOU COLAR NA QUERO NO SQL E DIGO AONDE COLAR-------------------------------
            _cmd = new SqlCommand(pQueryText, _conn);
        }
        public DataTable QueryDT()
        {
            /////------------------------- ME RETORNA UMA TABELA COM O RESULTADO-------------------------------
            _datadapter = new SqlDataAdapter(_cmd);
            _dt = new DataTable();
            _datadapter.Fill(_dt);
            return _dt;
        }
        public SqlDataReader QueryReader()
        {
            /////------------------------- EXECUTA A QUERY E -------------------------------
            /////------------------------- ME RETORNA UM LEITOR, PARA LER AS CELULAS DO RESULTADO DA QUERY-------------------------------
            _datareader = _cmd.ExecuteReader();
            return _datareader;
        }
        public void QueryRun()
        {
            /////------------------------- EXECUTA A QUERY(COMANDOS ---INSERT / UPDATE AKI-------------------------------
            _cmd.ExecuteNonQuery();
        }
        public void closeConnection()
        {
            /////------------------------- FECHO A CONEXAO-------------------------------
            _conn.Close();
            _conn.Dispose();
        }
    }
}
