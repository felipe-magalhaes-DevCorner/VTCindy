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
                


                FuncionarioItemCollection.FuncionarioCollection = FuncionariosDataHandler.StoreInformation(funcionarioArray, ListOfFuncionarios);

                
            }


            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            {
                txtnome.Text = ListOfFuncionarios[listBox1.SelectedIndex]._name.ToString();
                mskcpf.Text = ListOfFuncionarios[listBox1.SelectedIndex]._cpf.ToString();
                txtsexo.Text = ListOfFuncionarios[listBox1.SelectedIndex]._sexo.ToString();

                txtdn.Text = ListOfFuncionarios[listBox1.SelectedIndex]._dataNascimento.ToString("dd/MM/yyyy");
                txtrua.Text = ListOfFuncionarios[listBox1.SelectedIndex]._rua.ToString();
                txtxnumero.Text = ListOfFuncionarios[listBox1.SelectedIndex]._numero.ToString();
                txtcomplemento.Text = ListOfFuncionarios[listBox1.SelectedIndex]._complemento.ToString();
                txtbairro.Text = ListOfFuncionarios[listBox1.SelectedIndex]._bairro.ToString();
                txtobs.Text = ListOfFuncionarios[listBox1.SelectedIndex]._observacao.ToString();
                txtcidade.Text = ListOfFuncionarios[listBox1.SelectedIndex]._cidade.ToString();
                txtestado.Text = ListOfFuncionarios[listBox1.SelectedIndex]._estado.ToString();
                mskcep.Text = ListOfFuncionarios[listBox1.SelectedIndex]._cep.ToString();

            }
            


      


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       
    }
}
