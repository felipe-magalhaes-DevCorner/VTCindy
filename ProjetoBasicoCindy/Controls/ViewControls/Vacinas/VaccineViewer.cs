using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBasicoCindy.ViewControls.Vacinas
{
    public partial class VaccineViewer : UserControl
    {
        public VaccineViewer(string nome, string data, string lote, string unidade)
        {
            InitializeComponent();
            BackColor = Color.LightGray;
            Tag = nome;

            label1.Text = String.Format("Data:" + data);
            label2.Text = String.Format("Lote:" + lote);
            label3.Text = String.Format("Unid:" + unidade);
            
            LabelWrap(label1);
            LabelWrap(label2);                      
            LabelWrap(label3);
        }
        public VaccineViewer()
        {
            InitializeComponent();
            
            label1.Text = String.Format("Data:__/__/____" );
            label2.Text = String.Format("Lote:" );
            label3.Text = String.Format("Unid:" );
            LabelWrap(label1);
            LabelWrap(label2);
            LabelWrap(label3);
            BackColor = Color.Red;
        }
        public void LabelWrap(Label label)
        {
            label.MaximumSize = new Size(100, 0);
            label.AutoSize = true;
            
        }
    }
}
