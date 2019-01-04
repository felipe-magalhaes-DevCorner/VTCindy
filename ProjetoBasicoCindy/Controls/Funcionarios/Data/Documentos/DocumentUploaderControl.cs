using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public partial class DocumentUploaderControl : UserControl
    {
        private string _filename;
        private List<Image> _imageList = new List<Image>();
        private int _pageCount = 0;
        public float Matricula { get; set; }

        public DocumentUploaderControl()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filename = openFileDialog1.FileName;
                LoadImage(_filename, 1, 1);

            }
        }
        private void LoadImage(string file, int tipo, int pagina)
        {
            
            
            _imageList.Add(Image.FromFile(file));
            pictureBox1.Image = _imageList[_imageList.Count - 1];

            DocumentosPictureItem documentosPictureItem = new DocumentosPictureItem(_imageList[0], tipo, pagina);
            
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
            
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

        }
    }
}
