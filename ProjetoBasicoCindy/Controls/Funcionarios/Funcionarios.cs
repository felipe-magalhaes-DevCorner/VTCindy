using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBasicoCindy.Controls.Funcionarios
{
    public partial class Funcionarios : UserControl
    {
        public List<FuncionarioItem> ListOfFuncionarios = new List<FuncionarioItem>();
        public Funcionarios()
        {

            InitializeComponent();



        }


        private void Funcionarios_Load(object sender, EventArgs e)
        {
            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = "Select * from funcionario";
                db.SqlQuery(query);
                db.QueryRun();
                var _dt = db.QueryDT();
                

                StoreFuncionarioItem(_dt);





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
        private void StoreFuncionarioItem(DataTable _dados)
        {
            
            

            foreach (DataRow row in _dados.Rows)
            {
                var funcionarioArray = new List<string>();
                foreach (DataColumn column in _dados.Columns)
                {
                    funcionarioArray.Add(row[column].ToString());


                }
                listBox1.Items.Add(funcionarioArray[1]);
                ListOfFuncionarios = FuncionariosDataHandler.StoreInformation(funcionarioArray, ListOfFuncionarios);

                
            }


            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
