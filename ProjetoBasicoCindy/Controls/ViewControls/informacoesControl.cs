using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoBasicoCindy
{
    public partial class informacoesControl : UserControl
    {
        #region Variables
        public static string matricula = "0";
        public DataTable _dtb = new DataTable();
        public OnibusItem onibus = new OnibusItem();
        private int buslistviewIndexHelper = 0;
        #endregion

        #region Constructor
        public informacoesControl(FuncionarioItem _funcionario = null)
        {
            InitializeComponent();

            loadFunc(_funcionario);
        }

        #endregion

        #region UI Handlers
        private void OnibusTableHandler(List<OnibusItem> _onibus)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("");
            listView1.Columns.Add("Linha");
            
            listView1.Columns.Add("Preço");
            listView1.Columns.Add("Cartão");
            foreach (OnibusItem item in _onibus)
            {
                ListViewItem lvi = new ListViewItem();
                
                lvi.SubItems.Add(item._linha.Trim());
                lvi.SubItems.Add(String.Format("{0:0.00}", item._preco));
                lvi.SubItems.Add(item._cartao.Trim());
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
        public void setMatricula(string _matricula)
        {
            matricula = (Convert.ToInt32(_matricula) + 1).ToString();
            txtMatricula.Text = matricula.ToString().Trim();
        }

        #endregion

        #region Load
        public void loadFunc(FuncionarioItem _funcionario = null)
        {
            if (_funcionario != null)
            {
                matricula = _funcionario._idFuncionario.ToString().Trim();
                txtMatricula.Text = matricula;
                if (_funcionario._funcPic != null)
                {
                    pictureBox1.Image = _funcionario._funcPic;

                }
                txtIdentidade.Text = _funcionario._identidade.ToString().Trim();
                mskTel.Text = _funcionario._telefone.ToString().Trim();
                txtnome.Text = _funcionario._name.ToString().Trim();
                mskcpf.Text = _funcionario._cpf.ToString().Trim();
                mskTel.Text = _funcionario._telefone.ToString().Trim();
                cbSexo.Text = _funcionario._sexo.ToString().Trim();
                mskDataNasc.Text = _funcionario._dataNascimento.ToString("dd/MM/yyyy");
                txtrua.Text = _funcionario._rua.ToString().Trim();
                txtxnumero.Text = _funcionario._numero.ToString().Trim();
                txtcomplemento.Text = _funcionario._complemento.ToString().Trim();
                txtbairro.Text = _funcionario._bairro.ToString().Trim();
                rtxtObs.Text = _funcionario._observacao.ToString().Trim();
                txtcidade.Text = _funcionario._cidade.ToString().Trim();
                cbEstado.Text = _funcionario._estado.ToString().Trim();
                mskcep.Text = _funcionario._cep.ToString().Trim();
                CultureInfo cult = new CultureInfo("pt-BR");
                mskAdmissao.Text = _funcionario._adimissao.ToString("dd/MM/yyyy", cult);

                if (_funcionario._inativo == true)
                {
                    checkInativo.Checked = true;
                    
                    mskInativoData.Text = _funcionario._inativacao.ToString("dd/MM/yyyy", cult);
                }
                var Getonibus_list = new OnibusItemCollection();
                List<OnibusItem> onibus_list = Getonibus_list.GetFuncionarioOnibusCollection();
                OnibusTableHandler(onibus_list);
            }
        }
        #endregion

        #region addbuss
        /// <summary>
        /// handler for bus (onibus) handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btAddBus_Click(object sender, EventArgs e)
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
            var Getonibus_list = new OnibusItemCollection();

            List<OnibusItem> onibus_list = Getonibus_list.GetFuncionarioOnibusCollection();

            OnibusTableHandler(onibus_list);

            //always good to dispose

        }
        #endregion

        #region RemoveBus
        private void btRemoveBus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 )
            {
                var _getFun = new FuncionarioItemEdit();
                var _funcionario = _getFun.GetFuncionarioEdit();
                var GetBus = new OnibusItemCollection();
                GetBus.SetList(_funcionario._onibus);
                var listonibusEdit = new List<OnibusItem>();
                var testelist = new List<OnibusItem>();
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    ListViewItem _onibusItem = listView1.SelectedItems[i];
                    var onibusTodelete = new OnibusItem(buslistviewIndexHelper, _onibusItem.SubItems[0].Text, _onibusItem.SubItems[1].Text,Convert.ToDouble( _onibusItem.SubItems[2].Text));
                    listonibusEdit.Add(onibusTodelete);
                }
                foreach (OnibusItem onibusItem in listonibusEdit)
                {
                    testelist = GetBus.GetFuncionarioOnibusCollection();
                    GetBus.RemoveBusbyID(0);
                    testelist = GetBus.GetFuncionarioOnibusCollection();

                }

                //final list for visualization testes
                listonibusEdit = GetBus.GetFuncionarioOnibusCollection();
                OnibusTableHandler(listonibusEdit);
                _funcionario._onibus = GetBus.MakeListTOCollection();
                _getFun.SetFuncionarioEdit(_funcionario);




                //OnibusItem onibus = new OnibusItem(listView1.SelectedItems[0]);


            }






        }
        #endregion

        #region testeshandler


        private void AddVisibleChangedEventHandler()
        {
            panelAddBus.VisibleChanged += new EventHandler(this.Label_VisibleChanged);
        }

        private void Label_VisibleChanged(object sender, EventArgs e)
        {
            if (panelAddBus.Visible == false)
            {
                var Getonibus_list = new OnibusItemCollection();
                OnibusTableHandler(Getonibus_list.GetFuncionarioOnibusCollection());
            }
            
        }




        #endregion
        
        #region HelperClasses
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            buslistviewIndexHelper = e.ItemIndex;
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
