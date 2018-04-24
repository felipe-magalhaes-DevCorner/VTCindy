using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public partial class informacoesControl : UserControl
    {
        public static string matricula = "0";
        public DataTable _dtb = new DataTable();
        
        public informacoesControl(FuncionarioItem _funcionario = null)
        {
            InitializeComponent();
            
            loadFunc(_funcionario);
        }

        #region UI Handlers
        private void OnibusTableHandler(List<OnibusItem> _onibus)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("");
            listView1.Columns.Add("Linha");
            
            listView1.Columns.Add("Preço");
            listView1.Columns.Add("Cartão");
            foreach (OnibusItem item in _onibus)
            {
                ListViewItem lvi = new ListViewItem();
                
                lvi.SubItems.Add(item._linha.Trim());
                lvi.SubItems.Add(item._preco.ToString().Trim());
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



        public void setMatricula(string _matricula)
        {
            matricula = (Convert.ToInt32(_matricula) + 1).ToString() ;
            txtMatricula.Text = matricula.ToString().Trim();
        }
        public void loadFunc(FuncionarioItem _funcionario = null)
        {
            if (_funcionario != null)
            {
                matricula = _funcionario._idFuncionario.ToString().Trim();
                txtMatricula.Text = matricula;
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
                if (_funcionario._inativo == true)
                {
                    checkInativo.Checked = true;
                }
                var Getonibus_list = new OnibusItemCollection();
                List<OnibusItem> onibus_list = Getonibus_list.GetFuncionarioOnibusCollection();
                OnibusTableHandler(onibus_list);








                
            }
            




        }


        private void btAddBus_Click(object sender, EventArgs e)
        {

            var objAddBus = new AddBussViewModel();
            panelAddBus.Controls.Add(objAddBus);
            panelAddBus.BringToFront();
        }


    }
}
