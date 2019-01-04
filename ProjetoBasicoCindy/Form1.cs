using System;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public partial class Form1 : Form
    {
        private Control _buttoncontrol;
        public Form1()
        {
            InitializeComponent();






        }





        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {

        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            

            var objMainform = new Funcionarios();
            container.Controls.Add(objMainform);
            objMainform.ButtonCOntrol = _buttoncontrol;
            buttonContainer.Visible = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _buttoncontrol = new ButtonControl();

            buttonContainer.Controls.Add(_buttoncontrol);
            buttonContainer.Visible = false;
        }
    }
}
