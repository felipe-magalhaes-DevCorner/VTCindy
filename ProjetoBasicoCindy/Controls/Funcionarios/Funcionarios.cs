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

        //variables, main funcionarioitem collection
        #region variables
        //lista principal funcionarios

        public List<FuncionarioItem> ListOfFuncionarios = null;
        //variable de para uma unica conexcao sql por funcionario.
        DataBaseHandler DataSQL = new DataBaseHandler();
        static int FinalMatricula = 0;
        #endregion


        //inicializes control
        #region constructor
        public Funcionarios()
        {

            InitializeComponent();
            GetFuncPreview();



        }

        #endregion


        //loads funcionario data to permanent list of cuncionarios
        #region LOAD

        #region discontinued
        /// <summary
        /// ------------------------------------------ DISCONTINUED------------------------------
        /// deal with all information from DATATABLE(SQL) AND INSERTS INTO RIGHT FIELDS
        /// ABANDONED.
        /// </summary>
        /// <param name="_dt"></param>

        private void GetFuncionariosToList(DataTable _dt)
        {
            int aux = 0;
            List<FuncionarioItem> listFUncionarios = new List<FuncionarioItem>();

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
                string telefone = _dt.Rows[row][15].ToString();
                //GENERATES FUNCIONARIO ITEM WITH ALL INFO COLLECTED
                var funcionario = new FuncionarioItem(matricula, picture, nome, cpf, identidade, sexo, DN, rua, numero, complemento, bairro, observacao, cidade, estado, cep, telefone);
                listFUncionarios.Add(funcionario);
                //ADDS TO THE MAIN FUNCIONARIOITEMCOLLECION STATIC LIST
                var objData = new FuncionarioItemCollection();
                objData.SetList(listFUncionarios);
                ListOfFuncionarios = objData.GetFuncionariosList();
                //objData.AddFuncionario(funcionario);
                //ListOfFuncionarios = objData.GetFuncionariosList();
                //add to listview now, why waste another variable later.
                //listViewFuncionarioView(funcionario);
                row++;
                panelInfo.Controls.Clear();
                var objInformacoes = new informacoesControl();
                objInformacoes.setMatricula(aux.ToString());
                panelInfo.Controls.Add(objInformacoes);



            }
        }
        #endregion


        private void GetFuncPreview()
        {
            DataTable dtNomes = new DataTable();
            List<FuncionarioItemPreview> previewList = new List<FuncionarioItemPreview>();
            DataBaseHandler DBHandler = new DataBaseHandler();
            dtNomes = DBHandler.PreviewGetFuncionariosTolist();
            string nome = "";
            int matricula = 0;
            for (int x = 0; x < dtNomes.Rows.Count; x++)
            {
                for (int y = 0; y < dtNomes.Columns.Count; y++)
                {
                    if (y == 0)
                    {
                        matricula = Convert.ToInt32(dtNomes.Rows[x][y].ToString());
                    }
                    else
                    {
                        nome = dtNomes.Rows[x][y].ToString();
                    }

                    FuncionarioItemPreview AddFuncPreview = new FuncionarioItemPreview(matricula, nome);
                    
                    previewList.Add(AddFuncPreview);
                }
            }
            var Realist = new FuncionarioCollectionPreview();
            foreach (FuncionarioItemPreview funcionario in previewList)
            {
                listViewFuncionarioView(funcionario);

            }


        }
        private void listViewFuncionarioView(FuncionarioItemPreview _funcionario)
        {
            listBox1.Items.Add(_funcionario._name);
        }
        private void Funcionarios_Load(object sender, EventArgs e)
        {
            DataTable _dt;
            
            _dt = DataSQL.GetFuncionariosList();
            if (_dt.Rows.Count > 0)
            {
                //GetFuncionariosToList(_dt);
            }  
            



            #endregion



            /// HAS TO BE MOVED TO ITS OWN CONTROLLER.

            #region DOCUMENTO CONTROLLER TO
            //ColumnHeader header0 = new ColumnHeader();
            //ColumnHeader header1 = new ColumnHeader();
            //string[] columns = { "Documento", "Obrigatorio" };

            //header0.Text = "Documento";
            //header0.Width = 80;
            //header0.TextAlign = HorizontalAlignment.Center;
            //listviewDocuments.Columns.Add(header0);
            //header1.Text = "Obrigatorio";
            //header1.Width = 100;
            //header1.TextAlign = HorizontalAlignment.Center;
            //listviewDocuments.Columns.Add(header1);



            //listviewDocuments.View = View.Details;
            #endregion






        }
        








        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex >= 0)
            //{
            //    panelInfo.Controls.Clear();
            //    var objInformacoes = new informacoesControl(ListOfFuncionarios[listBox1.SelectedIndex]);
            //    panelInfo.Controls.Add(objInformacoes);

            //}
        
            

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
