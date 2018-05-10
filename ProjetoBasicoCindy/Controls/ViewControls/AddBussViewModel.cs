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
        public Panel ParentPanel { get; set; }
        public AddBussViewModel()
        {
            InitializeComponent();
        }


        


        #region click handler
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddBus_Click(object sender, EventArgs e)
        {
            
            
            var _getFun = new FuncionarioItemEdit();
            var _funcionario = _getFun.GetFuncionarioEdit();
            var GetBus = new OnibusItemCollection();

            GetBus.SetList(_funcionario._onibus);
            int id = GetBus.COuntList() + 1;
            //----------------------working now------------------
            if (txtLinha.Text.Trim() != "" & cbCartao.Text.Trim() != "")
            {
                var onibus = new OnibusItem(id, txtLinha.Text.Trim(), cbCartao.Text.Trim(), Convert.ToDouble(txtPreco.Text.Trim()));
                GetBus.AddBus(onibus);
                int id2 = GetBus.COuntList() + 1;
            }
            _funcionario._onibus = GetBus.MakeListTOCollection();
            ParentPanel.Visible = false;
            ParentPanel.SendToBack();
            ParentPanel.Controls.Clear();
            int[] a = new int[5];
            







        }

        //remove "Observação on click"
        private void richTXTobs_Click(object sender, EventArgs e)
        {
            richTXTobs.Text = "";

        }
        //dispose and bring to back add buss
        private void button1_Click(object sender, EventArgs e)
        {
            ParentPanel.Controls.Clear();
            ParentPanel.SendToBack();
            this.Dispose();
        }
        #endregion



    }
}
