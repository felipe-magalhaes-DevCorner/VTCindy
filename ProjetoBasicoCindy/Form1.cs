using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public partial class Form1 : Form
    {
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
            

            var objMainform = new Controls.Funcionarios.Funcionarios();
            container.Controls.Add(objMainform);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
