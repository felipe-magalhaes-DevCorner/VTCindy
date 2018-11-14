using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonthCalendar = Pabo.Calendar.MonthCalendar;

namespace ProjetoBasicoCindy
{
    public partial class Form1 : Form
    {
        private Control buttoncontrol;
        public Form1()
        {
            InitializeComponent();






        }





        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {

        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            

            var objMainform = new Funcionarios();
            container.Controls.Add(objMainform);
            objMainform.buttonCOntrol = buttoncontrol;
            buttonContainer.Visible = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttoncontrol = new ButtonControl();

            buttonContainer.Controls.Add(buttoncontrol);
            buttonContainer.Visible = false;
        }
    }
}
