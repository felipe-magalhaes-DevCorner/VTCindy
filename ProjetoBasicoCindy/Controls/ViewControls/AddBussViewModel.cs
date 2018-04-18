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
    public partial class AddBussViewModel : UserControl
    {
        public AddBussViewModel()
        {
            InitializeComponent();
        }

        private void btAddBus_Click(object sender, EventArgs e)
        {
            int id = 2;
            var onibus = new OnibusItem(id, cbLinhas.Text.Trim(), cbCartao.Text.Trim(), richTXTobs.Text.Trim());
        }
        private void LoadBasicInformation(OnibusItem _onibus)
        {
            

        }

        private void richTXTobs_Click(object sender, EventArgs e)
        {
            richTXTobs.Text = "";

        }
    }
}
