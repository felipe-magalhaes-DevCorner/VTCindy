using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoBasicoCindy
{
    public partial class InformacoesControl : UserControl
    {
        #region Variables
        public static string Matricula = "0";
        public DataTable Dtb = new DataTable();
        public OnibusItem Onibus = new OnibusItem();
        private int _buslistviewIndexHelper = 0;
        #endregion

        #region Constructor
        public InformacoesControl(FuncionarioItem funcionario = null)
        {
            InitializeComponent();

            LoadFunc(funcionario);
        }

        #endregion

        #region UI Handlers
        private void OnibusTableHandler(List<OnibusItem> onibus)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("");
            listView1.Columns.Add("Linha");
            
            listView1.Columns.Add("Preço");
            listView1.Columns.Add("Cartão");
            foreach (OnibusItem item in onibus)
            {
                ListViewItem lvi = new ListViewItem();
                
                lvi.SubItems.Add(item.Linha.Trim());
                lvi.SubItems.Add(String.Format("{0:0.00}", item.Preco));
                lvi.SubItems.Add(item.Cartao.Trim());
                listView1.Items.Add(lvi);
                
                listView1.Columns[0].Width = 0;
                listView1.Columns[1].Width = 60;
                listView1.Columns[2].Width = 40;
                listView1.Columns[3].Width = 90;
                
                int size = listView1.Columns[0].Width + listView1.Columns[1].Width + listView1.Columns[2].Width + listView1.Columns[3].Width + 8;

                listView1.Width = size;
                //

            }
        }

        #endregion

        #region MatiChange
        public void SetMatricula(string matricula)
        {
            Matricula = (Convert.ToInt32(matricula) + 1).ToString();
            txtMatricula.Text = Matricula.ToString().Trim();
        }

        #endregion

        #region Load
        public void LoadFunc(FuncionarioItem funcionario = null)
        {
            if (funcionario != null)
            {
                Matricula = funcionario.IdFuncionario.ToString().Trim();
                txtMatricula.Text = Matricula;
                if (funcionario.FuncPic != null)
                {
                    pictureBox1.Image = funcionario.FuncPic;

                }
                txtIdentidade.Text = funcionario.Identidade.ToString().Trim();
                mskTel.Text = funcionario.Telefone.ToString().Trim();
                txtnome.Text = funcionario.Name.ToString().Trim();
                mskcpf.Text = funcionario.Cpf.ToString().Trim();
                mskTel.Text = funcionario.Telefone.ToString().Trim();
                cbSexo.Text = funcionario.Sexo.ToString().Trim();
                mskDataNasc.Text = funcionario.DataNascimento.ToString("dd/MM/yyyy");
                txtrua.Text = funcionario.Rua.ToString().Trim();
                txtxnumero.Text = funcionario.Numero.ToString().Trim();
                txtcomplemento.Text = funcionario.Complemento.ToString().Trim();
                txtbairro.Text = funcionario.Bairro.ToString().Trim();
                rtxtObs.Text = funcionario.Observacao.ToString().Trim();
                txtcidade.Text = funcionario.Cidade.ToString().Trim();
                cbEstado.Text = funcionario.Estado.ToString().Trim();
                mskcep.Text = funcionario.Cep.ToString().Trim();
                CultureInfo cult = new CultureInfo("pt-BR");
                mskAdmissao.Text = funcionario.Adimissao.ToString("dd/MM/yyyy", cult);

                if (funcionario.Inativo == true)
                {
                    checkInativo.Checked = true;
                    
                    mskInativoData.Text = funcionario.Inativacao.ToString("dd/MM/yyyy", cult);
                }
                var getonibusList = new OnibusItemCollection();
                List<OnibusItem> onibusList = getonibusList.GetFuncionarioOnibusCollection();
                OnibusTableHandler(onibusList);
            }
        }
        #endregion

        #region addbuss
        /// <summary>
        /// handler for bus (onibus) handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtAddBus_Click(object sender, EventArgs e)
        {
            //opens pannel to add bus
            var objAddBus = new AddBussViewModel();
            //pass parent panel to be brought to back later on close button
            objAddBus.ParentPanel = panelAddBus;
            objAddBus.ParentPanel.Visible = true;
            //add to control

            panelAddBus.Controls.Add(objAddBus);
            //bring panel to front
            panelAddBus.BringToFront();
            var getonibusList = new OnibusItemCollection();

            List<OnibusItem> onibusList = getonibusList.GetFuncionarioOnibusCollection();

            OnibusTableHandler(onibusList);

            //always good to dispose

        }
        #endregion

        #region RemoveBus
        private void BtRemoveBus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 )
            {
                var getFun = new FuncionarioItemEdit();
                var funcionario = getFun.GetFuncionarioEdit();
                var getBus = new OnibusItemCollection();
                getBus.SetList(funcionario.Onibus);
                var listonibusEdit = new List<OnibusItem>();
                var testelist = new List<OnibusItem>();
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    ListViewItem onibusItem = listView1.SelectedItems[i];
                    var onibusTodelete = new OnibusItem(_buslistviewIndexHelper, onibusItem.SubItems[0].Text, onibusItem.SubItems[1].Text,Convert.ToDouble( onibusItem.SubItems[2].Text));
                    listonibusEdit.Add(onibusTodelete);
                }
                foreach (OnibusItem onibusItem in listonibusEdit)
                {
                    testelist = getBus.GetFuncionarioOnibusCollection();
                    getBus.RemoveBusbyId(0);
                    testelist = getBus.GetFuncionarioOnibusCollection();

                }

                //final list for visualization testes
                listonibusEdit = getBus.GetFuncionarioOnibusCollection();
                OnibusTableHandler(listonibusEdit);
                funcionario.Onibus = getBus.MakeListToCollection();
                getFun.SetFuncionarioEdit(funcionario);




                //OnibusItem onibus = new OnibusItem(listView1.SelectedItems[0]);


            }






        }
        #endregion

        #region testeshandler


        private void AddVisibleChangedEventHandler()
        {
            panelAddBus.VisibleChanged += new EventHandler(Label_VisibleChanged);
        }

        private void Label_VisibleChanged(object sender, EventArgs e)
        {
            if (panelAddBus.Visible == false)
            {
                var getonibusList = new OnibusItemCollection();
                OnibusTableHandler(getonibusList.GetFuncionarioOnibusCollection());
            }
            
        }




        #endregion
        
        #region HelperClasses
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _buslistviewIndexHelper = e.ItemIndex;
        }
        private void checkInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInativo.Checked == true)
            {
                lbinativo.Visible = true;
                mskInativoData.Visible = true;
            }
            else
            {
                lbinativo.Visible = false;
                mskInativoData.Visible = false;

            }
        }



        #endregion




    }
}
