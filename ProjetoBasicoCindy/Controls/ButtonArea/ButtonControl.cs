using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public partial class ButtonControl : UserControl
    {
        public ButtonControl()
        {
            InitializeComponent();
        }
        public void ButtonVisible(bool view)
        {
            if (view)
            {
                Visible = true;
            }
            else
            {
                Visible = false;
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (btEdit.BackColor != Color.Transparent)
            {
                btEdit.BackColor = Color.Transparent;
            }


        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (btEdit.BackColor == Color.Transparent)
            {
                btEdit.BackColor = ColorTranslator.FromHtml("#E7EFF2");
            }
        }
    }
}
