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
    public partial class ButtonControl : UserControl
    {
        public ButtonControl()
        {
            InitializeComponent();
        }
        public void ButtonVisible(bool _view)
        {
            if (_view)
            {
                this.Visible = true;
            }
            else
            {
                this.Visible = false;
            }
            
        }
    }
}
