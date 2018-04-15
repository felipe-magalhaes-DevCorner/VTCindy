using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoBasicoCindy
{
    public partial class Funcionarios : UserControl
    {
        public List<FuncionarioItem> ListOfFuncionarios = FuncionarioItemCollection.GetFuncionariosList();
        public Funcionarios()
        {

            InitializeComponent();



        }
        /// <summary>
        /// LOAD AREA
        /// </summary>
        /// <param name="_dt"></param>
        #region LOAD
        private void GetFuncionariosToList(DataTable _dt)
        {

            foreach (DataRow rows in _dt.Rows)
            {
                //helper less conversions
                int row = Convert.ToInt32(rows);
                //matricula
                int matricula = Convert.ToInt32(_dt.Rows[row][0]);
                //deal if date is a picture
                Byte[] data = new Byte[0];
                data = (Byte[])(_dt.Rows[row][1]);
                MemoryStream mem = new MemoryStream(data);
                Image picture;
                picture = Image.FromStream(mem);
                //nome.... etc
                string nome = _dt.Rows[row][2].ToString();
                string cpf = _dt.Rows[row][3].ToString();
                string identidade = _dt.Rows[row][4].ToString();
                string sexo = _dt.Rows[row][5].ToString();
                DateTime DN = Convert.ToDateTime(_dt.Rows[row][6]);
                string rua = _dt.Rows[row][7].ToString();
                string numero = _dt.Rows[row][8].ToString();
                string complemento = _dt.Rows[row][9].ToString();
                string bairro = _dt.Rows[row][10].ToString();
                string observacao = _dt.Rows[row][11].ToString();
                string cidade = _dt.Rows[row][12].ToString();
                string estado = _dt.Rows[row][13].ToString();
                string cep = _dt.Rows[row][14].ToString();
                //GENERATES FUNCIONARIO ITEM WITH ALL INFO COLLECTED
                var funcionario = new FuncionarioItem(matricula, picture, nome, cpf, identidade, sexo, DN, rua, numero, complemento, bairro, observacao, cidade, estado, cep);
                //ADDS TO THE MAIN FUNCIONARIOITEMCOLLECION STATIC LIST
                FuncionarioItemCollection.AddFuncionario(funcionario);
                //add to listview now, why waste another variable later.
                listBox1.Items.Add(nome);
                
            }
        }
        private void Funcionarios_Load(object sender, EventArgs e)
        {
            #region PopulateListView
            var db = new ConnectionClass_SQL.ConnectionClass();
            try
            {
                db.SqlConnection();
                var query = "Select * from funcionario";
                db.SqlQuery(query);
                db.QueryRun();
                var _dt = db.QueryDT();
                GetFuncionariosToList(_dt);

                
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
            #endregion

            #region load row into funcionariolist

            #endregion
            #region ViewControls
            #region ListViewConstructor
            ColumnHeader header0 = new ColumnHeader();
            ColumnHeader header1 = new ColumnHeader();
            string[] columns = { "Documento", "Obrigatorio" };

            header0.Text = "Documento";
            header0.Width = 80;
            header0.TextAlign = HorizontalAlignment.Center;
            listviewDocuments.Columns.Add(header0);
            header1.Text = "Obrigatorio";
            header1.Width = 100;
            header1.TextAlign = HorizontalAlignment.Center;
            listviewDocuments.Columns.Add(header1);



            listviewDocuments.View = View.Details;
            #endregion

            #endregion




        }
        #endregion





        private void listViewFuncionarioView(FuncionarioItem _funcionario)
        {

            listBox1.Items.Add(_funcionario._name);



        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            {
                txtMatricula.Text = ListOfFuncionarios[listBox1.SelectedIndex]._idFuncionario.ToString();
                txtIdentidade.Text = ListOfFuncionarios[listBox1.SelectedIndex]._identidade.ToString();
                txtnome.Text = ListOfFuncionarios[listBox1.SelectedIndex]._name.ToString();
                mskcpf.Text = ListOfFuncionarios[listBox1.SelectedIndex]._cpf.ToString();
                cbSexo.Text = ListOfFuncionarios[listBox1.SelectedIndex]._sexo.ToString();
                mskDataNasc.Text = ListOfFuncionarios[listBox1.SelectedIndex]._dataNascimento.ToString("dd/MM/yyyy");
                txtrua.Text = ListOfFuncionarios[listBox1.SelectedIndex]._rua.ToString();
                txtxnumero.Text = ListOfFuncionarios[listBox1.SelectedIndex]._numero.ToString();
                txtcomplemento.Text = ListOfFuncionarios[listBox1.SelectedIndex]._complemento.ToString();
                txtbairro.Text = ListOfFuncionarios[listBox1.SelectedIndex]._bairro.ToString();
                rtxtObs.Text = ListOfFuncionarios[listBox1.SelectedIndex]._observacao.ToString();
                txtcidade.Text = ListOfFuncionarios[listBox1.SelectedIndex]._cidade.ToString();
                cbEstado.Text = ListOfFuncionarios[listBox1.SelectedIndex]._estado.ToString();
                mskcep.Text = ListOfFuncionarios[listBox1.SelectedIndex]._cep.ToString();

            }
            //ListOfFuncionarios[listBox1.SelectedIndex]







        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btNewPic_Click(object sender, EventArgs e)
        {
            panelUploadControl.Visible = true;
            panelUploadControl.BringToFront();
            var objUploadControl = new DocumentUploaderControl();
            //objUploadControl. = 
            panelUploadControl.Dock = DockStyle.Fill;
            //objUploadControl.ParentPanel = panelUploadControl;
            panelUploadControl.Controls.Add(objUploadControl);





        }

        private void tabDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
