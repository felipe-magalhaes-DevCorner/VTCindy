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
            
            loadFunc(matricula, _funcionario);
        }
        public void setMatricula(string _matricula)
        {
            matricula = (Convert.ToInt32(_matricula) + 1).ToString() ;
            txtMatricula.Text = matricula.ToString().Trim();
        }
        private void loadFunc(string _matricula, FuncionarioItem _funcionario = null)
        {
            if (_funcionario != null)
            {
                matricula = _funcionario._idFuncionario.ToString().Trim();
                txtMatricula.Text = matricula;
                txtIdentidade.Text = _funcionario._identidade.ToString().Trim();
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
            }
            var objGetBus = new DataBaseHandler();
            DataTable dtb = objGetBus.GetBus(matricula);
            dtBus.DataSource = dtb;
            dtBus.RowHeadersVisible = false;
            dtBus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;




        }
        public void ListViewBus(DataTable _onibus)
        {
            dtBus.DataSource = _onibus;
        }

        private void btAddBus_Click(object sender, EventArgs e)
        {

            var objAddBus = new AddBussViewModel();
            panelAddBus.Controls.Add(objAddBus);
            panelAddBus.BringToFront();
        }
    }
}
