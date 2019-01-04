using System;
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
            
            
            var getFun = new FuncionarioItemEdit();
            var funcionario = getFun.GetFuncionarioEdit();
            var getBus = new OnibusItemCollection();

            getBus.SetList(funcionario.Onibus);
            int id = getBus.COuntList() + 1;
            //----------------------working now------------------
            if (txtLinha.Text.Trim() != "" & cbCartao.Text.Trim() != "")
            {
                var onibus = new OnibusItem(id, txtLinha.Text.Trim(), cbCartao.Text.Trim(), Convert.ToDouble(txtPreco.Text.Trim()));
                getBus.AddBus(onibus);
                int id2 = getBus.COuntList() + 1;
            }
            funcionario.Onibus = getBus.MakeListToCollection();
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
            Dispose();
        }
        #endregion



    }
}
