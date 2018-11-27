using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBasicoCindy.ViewControls.Vacinas
{
    public partial class VaccineViewer : UserControl
    {
        public VaccineViewer(string nome, string data, string lote, string unidade)
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
            this.Tag = nome;
            label1.Text = String.Format("Data:" + data);
            label2.Text = String.Format("Lote:" + lote);
            label3.Text = String.Format("Unid:" + unidade);
        }
        public VaccineViewer()
        {
            InitializeComponent();
            
            label1.Text = String.Format("Data:__/__/____" );
            label2.Text = String.Format("Lote:" );
            label3.Text = String.Format("Unid:" );
        }
    }
}
