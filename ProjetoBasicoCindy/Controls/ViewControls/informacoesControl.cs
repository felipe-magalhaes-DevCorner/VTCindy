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
        public static int matricula = 0;
        public informacoesControl(FuncionarioItem _funcionario = null)
        {
            InitializeComponent();
            loadFunc(matricula, _funcionario);
        }
        public void setMatricula(int _matricula)
        {
            matricula = _matricula + 1;
            txtMatricula.Text = matricula.ToString();
        }
        private void loadFunc(int _matricula, FuncionarioItem _funcionario = null)
        {
            if (_funcionario != null)
            {
                string matricula = _funcionario._idFuncionario.ToString().Trim();
                txtMatricula.Text = matricula;
                txtIdentidade.Text = _funcionario._identidade.ToString();
                txtnome.Text = _funcionario._name.ToString();
                mskcpf.Text = _funcionario._cpf.ToString();
                mskTel.Text = _funcionario._telefone.ToString();
                cbSexo.Text = _funcionario._sexo.ToString();
                mskDataNasc.Text = _funcionario._dataNascimento.ToString("dd/MM/yyyy");
                txtrua.Text = _funcionario._rua.ToString();
                txtxnumero.Text = _funcionario._numero.ToString();
                txtcomplemento.Text = _funcionario._complemento.ToString();
                txtbairro.Text = _funcionario._bairro.ToString();
                rtxtObs.Text = _funcionario._observacao.ToString();
                txtcidade.Text = _funcionario._cidade.ToString();
                cbEstado.Text = _funcionario._estado.ToString();
                mskcep.Text = _funcionario._cep.ToString();
            }
            


        }
        public void ListViewBus(DataTable _onibus)
        {
            dtBus.DataSource = _onibus;
        }

    }
}
