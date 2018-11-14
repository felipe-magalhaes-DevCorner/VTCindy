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
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        public List<FuncionarioItem> ListOfFuncionarios = null;
        //variable de para uma unica conexcao sql por funcionario.
        DataBaseHandler DataSQL = new DataBaseHandler();
        //variavel auxiliar para controle de ultimo numero de matricula funcionario;

        public Control buttonCOntrol { get; set; }
        


        /// <summary>
        /// list to store funcionario item previews.
        /// an array with (matricula, nome_funcionario)
        /// </summary>
        List<FuncionarioItemPreview> previewList = new List<FuncionarioItemPreview>();
        #endregion


        //inicializes control
        #region constructor
        public Funcionarios()
        {

            InitializeComponent();
            //RUNS THE METHOD TO GET THE PREVIEW OF ALL FUNCIONARIOS
            GetFuncPreview();
        }

        #endregion


        //loads funcionario data to permanent list of cuncionarios


        #region discontinued
        /// <summary
        /// ------------------------------------------ DISCONTINUED------------------------------
        /// deal with all information from DATATABLE(SQL) AND INSERTS INTO RIGHT FIELDS
        /// ABANDONED.
        /// </summary>
        /// <param name="_dt"></param>


        #endregion



           
        #region FuncionarioPreviewGenerator

        
           

        private void GetFuncPreview()
        {
            DataTable dtNomes = new DataTable();
            
            DataBaseHandler DBHandler = new DataBaseHandler();
            dtNomes = DBHandler.PreviewGetFuncionariosTolist();
            string nome = "";
            int matricula = 0;
            FuncionarioItemPreview AddFuncPreview = new FuncionarioItemPreview();
            
            
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




                    }
                    FuncionarioItemPreview AddFuncPr = new FuncionarioItemPreview(matricula, nome);
                    previewList.Add(AddFuncPr);
                }
                var Realist = new FuncionarioCollectionPreview();
                //Adiciona nomes à list view
                foreach (FuncionarioItemPreview funcionario in previewList)
                {
                    listBox1.Items.Add(funcionario._name);

                }

            
            


        }
        #endregion


        #region DISCONTINUED

        /// <summary>
        ///----------------------------------------- DISCONTINUED-----------------------------------
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Funcionarios_Load(object sender, EventArgs e)
        {
            var LoadBankInformaacoaoControle = new informacoesControl();
            panelInfo.Controls.Add(LoadBankInformaacoaoControle);
            //DataTable _dt;

            //_dt = DataSQL.GetFuncionariosToList();
            //if (_dt.Rows.Count > 0)
            //{
            //    //GetFuncionariosToList(_dt);
            //}  

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

        #endregion

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


        /// <summary>
        /// handlers for listview select funcionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region ListView click
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedFuncionarioInfo();

        }
        private void LoadSelectedFuncDocs()
        {
            var objSQL = new DataBaseHandler();
            var objHandler = new SQLToSharpHandler();



        }

        private void LoadSelectedFuncionarioInfo()
        {
            var objSQL = new DataBaseHandler();
            var objHandler = new SQLToSharpHandler();
            //buscar informacoes do funcionario
            if (listBox1.SelectedIndex >= 0)
            {
                FuncionarioItem _Funcionario = objHandler.ConvertoFromSqlTo_1_FuncionarioItem(objSQL.GetFuncionariosInfo(previewList[listBox1.SelectedIndex]._idfuncionario.ToString()));
                objSQL.GetDocuments(_Funcionario._idFuncionario);
                var FuncionarioSelected = new FuncionarioItemEdit();
                FuncionarioSelected.SetFuncionarioEdit(_Funcionario);
                var objInformacoes = new informacoesControl(FuncionarioSelected.GetFuncionarioEdit());
                panelInfo.Controls.Clear();
                panelInfo.Controls.Add(objInformacoes);
            }
            
        }
        #endregion

        private void txFuncNameFilter_TextChanged(object sender, EventArgs e)
        {

            try
            {
                listBox1.Items.Clear();
                txFuncNameFilter.AutoCompleteMode = AutoCompleteMode.Suggest;
                source.Clear();
                string filter = txFuncNameFilter.Text;




                foreach (FuncionarioItemPreview _funcionario in previewList)
                {
                    if (_funcionario._name.ToLower().Contains((filter).ToLower()))
                    {
                        source.Add(_funcionario._name);
                        listBox1.Items.Add(_funcionario._name);
                    }




                }

                txFuncNameFilter.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txFuncNameFilter.AutoCompleteCustomSource = source;
            }
            catch (Exception)
            {


            }
        }
        public string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return String.Empty;

            byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(texto);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        /// Method to press enter and load funcionario info from textbox filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txFuncNameFilter_KeyDown(object sender, KeyEventArgs e)
        {
            //key enter event
            if (e.KeyCode == Keys.Enter)
            {
                //checks if the listview has the name on textbox
                if (listBox1.Items.Count > 0)
                {
                    int index = listBox1.FindStringExact(txFuncNameFilter.Text);
                    listBox1.SelectedIndex = index;
                }
                //display message case it doesnt
                else
                {
                    MessageBox.Show("Nao existe tal funcionario");
                }
                

            }

        }


        //TAB CONTROLLERS FOR HANDLERS OF TAB FUNCIONARIO
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                switch (tabControl1.SelectedIndex)
                {
                    //INFORMATION
                    case 0:

                        break;

                    //DOCUMENTOS
                    case 1:

                        break;

                    //FERIAS
                    case 2:

                        Ferias.FeriasHandler objFerias = new Ferias.FeriasHandler(flowFerias);


                        break;
                    //VACINA
                    case 3:
                        Vacina.VaccineHandler objVacina = new Vacina.VaccineHandler(flowPVacina);
                        //                    objVacina.vacinaPanel = flowPVacina;





                        break;
                    //EXAMES
                    case 4:

                        break;
                    //FERIAS


                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("è nescessario escolher 1 funcionario antes");
            }
            
        }
    }
}
