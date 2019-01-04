using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public partial class Funcionarios : UserControl
    {

        //variables, main funcionarioitem collection
        #region variables
        //lista principal funcionarios
        private AutoCompleteStringCollection _source = new AutoCompleteStringCollection();
        public List<FuncionarioItem> ListOfFuncionarios = null;
        //variable de para uma unica conexcao sql por funcionario.
        private DataBaseHandler _dataSql = new DataBaseHandler();
        //variavel auxiliar para controle de ultimo numero de matricula funcionario;

        public Control ButtonCOntrol { get; set; }
        


        /// <summary>
        /// list to store funcionario item previews.
        /// an array with (matricula, nome_funcionario)
        /// </summary>
        private List<FuncionarioItemPreview> _previewList = new List<FuncionarioItemPreview>();
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
            
            DataBaseHandler dbHandler = new DataBaseHandler();
            dtNomes = dbHandler.PreviewGetFuncionariosTolist();
            string nome = "";
            int matricula = 0;
            FuncionarioItemPreview addFuncPreview = new FuncionarioItemPreview();
            
            
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
                    FuncionarioItemPreview addFuncPr = new FuncionarioItemPreview(matricula, nome);
                    _previewList.Add(addFuncPr);
                }
                var realist = new FuncionarioCollectionPreview();
                //Adiciona nomes à list view
                foreach (FuncionarioItemPreview funcionario in _previewList)
                {
                    listBox1.Items.Add(funcionario.Name);

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
            var loadBankInformaacoaoControle = new InformacoesControl();
            panelInfo.Controls.Add(loadBankInformaacoaoControle);
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
            var objSql = new DataBaseHandler();
            var objHandler = new SqlToSharpHandler();



        }

        private void LoadSelectedFuncionarioInfo()
        {
            var objSql = new DataBaseHandler();
            var objHandler = new SqlToSharpHandler();
            //buscar informacoes do funcionario
            if (listBox1.SelectedIndex >= 0)
            {
                FuncionarioItem funcionario = objHandler.ConvertoFromSqlTo_1_FuncionarioItem(objSql.GetFuncionariosInfo(_previewList[listBox1.SelectedIndex].Idfuncionario.ToString()));
                objSql.GetDocuments(funcionario.IdFuncionario);
                var functesteequals = funcionario;
                var funcionarioSelected = new FuncionarioItemEdit();
                
                funcionarioSelected.SetFuncionarioEdit(functesteequals);
                bool teste = funcionario.Equals(funcionarioSelected.GetFuncionarioEdit());
                var objInformacoes = new InformacoesControl(funcionarioSelected.GetFuncionarioEdit());
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
                _source.Clear();
                string filter = txFuncNameFilter.Text;




                foreach (FuncionarioItemPreview funcionario in _previewList)
                {
                    if (funcionario.Name.ToLower().Contains((filter).ToLower()))
                    {
                        _source.Add(funcionario.Name);
                        listBox1.Items.Add(funcionario.Name);
                    }




                }

                txFuncNameFilter.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txFuncNameFilter.AutoCompleteCustomSource = _source;
            }
            catch (Exception)
            {


            }
        }
        public string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return String.Empty;

            byte[] bytes = Encoding.GetEncoding("iso-8859-8").GetBytes(texto);
            return Encoding.UTF8.GetString(bytes);
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
                        flowFerias.AutoSize = false;
                        Ferias.FeriasHandler objFerias = new Ferias.FeriasHandler(flowFerias);


                        break;
                    //VACINA
                    case 3:
                        Vacina.VaccineHandler objVacina = new Vacina.VaccineHandler(flowPVacina);
                        //                    objVacina.vacinaPanel = flowPVacina;





                        break;
                    //EXAMES
                    case 4:
                        Exames.ExamViewHandler examViewHandler = new Exames.ExamViewHandler(pnExames);

                        break;
                    


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
