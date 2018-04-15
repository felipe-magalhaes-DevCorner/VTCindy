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
    public partial class DocumentUploaderControl : UserControl
    {
        string filename;
        List<Image> ImageList = new List<Image>();
        int pageCount = 0;
        public float _matricula { get; set; }

        public DocumentUploaderControl()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                LoadImage(filename);

            }
        }
        private void LoadImage(string file)
        {
            
            
            ImageList.Add(Image.FromFile(file));
            pictureBox1.Image = ImageList[ImageList.Count - 1];

            DocumentosPictureItem documentosPictureItem = new DocumentosPictureItem(_matricula, ImageList, ImageList.Count);
            
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
            
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

        }
    }
}
