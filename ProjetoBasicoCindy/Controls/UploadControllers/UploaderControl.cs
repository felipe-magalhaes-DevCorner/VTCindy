using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ProjetoBasicoCindy
{
    public partial class UploaderControl : UserControl
    {
        #region Variables

        private Size _size = new Size();
        private Point _point = new Point();
        private Bitmap _testeimage;
        private List<Bitmap> _cropedImages = new List<Bitmap>();
        private string[] _fileNames;
        private static string _cfilename;
        private List<Bitmap> _images = new List<Bitmap>();
        private bool _isMouseDown = false;
        private Bitmap _insertImage;
        private int _index = 0;
        public Panel ParentPanel { get; set; }
        #endregion

        #region Members


        private Container _components = null;

        #endregion

        #region Constants

        private double _zoomfactor = 1.05;   // = 25% smaller or larger
        private int _minmax = 5;             // 5 times bigger or smaller than the ctrl

        #endregion
        public UploaderControl()
        {
            InitializeComponent();
            //InitCtrl();
        }

        #region Mouse events

        /// <summary>
        /// We use the mousewheel to zoom the picture in or out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                if (e.Delta < 0)
                {

                    ZoomOut();
                }
                else
                {
                    ZoomIn();
                }
            }

        }

        /// <summary>
        /// Make sure that the PicBox have the focus, otherwise it doesn´t receive 
        /// mousewheel events !.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicBox_MouseEnter(object sender, EventArgs e)
        {
            if (PicBox.Focused == false)
            {
                PicBox.Focus();
            }
        }

        #endregion
        #region Other Methods

        /// <summary>
        /// Special settings for the picturebox ctrl
        /// </summary>
        private void InitCtrl()
        {
            PicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            PicBox.Location = new Point(0, 0);
            OuterPanel.Dock = DockStyle.Fill;
            //OuterPanel.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            OuterPanel.AutoScroll = true;
            //OuterPanel.MouseEnter += new EventHandler(PicBox_MouseEnter);
            //PicBox.MouseEnter += new EventHandler(PicBox_MouseEnter);
            //OuterPanel.MouseWheel += new MouseEventHandler(PicBox_MouseWheel);
        }

        /// <summary>
        /// Create a simple red cross as a bitmap and display it in the picturebox
        /// </summary>
        private void RedCross()
        {
            Bitmap bmp = new Bitmap(OuterPanel.Width, OuterPanel.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            Graphics gr;
            gr = Graphics.FromImage(bmp);
            Pen pencil = new Pen(Color.Red, 5);
            gr.DrawLine(pencil, 0, 0, OuterPanel.Width, OuterPanel.Height);
            gr.DrawLine(pencil, 0, OuterPanel.Height, OuterPanel.Width, 0);
            PicBox.Image = bmp;
            gr.Dispose();
        }

        #endregion



        private void btUpload_Click_1(object sender, EventArgs e)
        {
            _images.Clear();
            _cropedImages.Clear();
            var dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _fileNames = dlg.FileNames;
                foreach (var fileName in dlg.FileNames)
                {
                    _images.Add(new Bitmap(fileName));
                    _cfilename = fileName;
                    _testeimage = new Bitmap(fileName);
                }
                PicBox.Image = Foo(_testeimage);
                PicBox.SizeMode = PictureBoxSizeMode.AutoSize;




            }

        }




        #region CropHandler
        private void Crop_Release()
        {
            _cropedImages.Clear();
            foreach (var image in _images)
            {
                var cropedImage = new Bitmap(_size.Width, _size.Height);
                for (int i = 0; i < _size.Width; i++)
                {
                    for (int j = 0; j < _size.Height; j++)
                    {
                        cropedImage.SetPixel(i, j, image.GetPixel(i + _point.X, j + _point.Y));
                    }
                }
                _cropedImages.Add(cropedImage);
            }
            pictureBox2.Visible = true;
            pictureBox2.Image = _cropedImages[0];          
                _cropedImages[0].Save(_fileNames[0].Replace(".", "cr."));
            _testeimage = _cropedImages[0];
            pictureBox1.Image = _testeimage;
            pictureBox2.Image = _testeimage;
            pictureBox2.Visible = true;
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Foo(_cropedImages[0]);
            //pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;




            //for (int i = 0; i < fileNames.Length; i++)
            //{
            //    cropedImages[0].Save(fileNames[i].Replace(".", "cr."));
            //}
        }
        #endregion

        #region Zooming Methods

        /// <summary>
        /// Make the PictureBox dimensions larger to effect the Zoom.
        /// </summary>
        /// <remarks>Maximum 5 times bigger</remarks>
        private void ZoomIn()
        {
            if ((PicBox.Width < (_minmax * OuterPanel.Width)) &&
                (PicBox.Height < (_minmax * OuterPanel.Height)))
            {
                PicBox.Width = Convert.ToInt32(PicBox.Width * _zoomfactor);
                PicBox.Height = Convert.ToInt32(PicBox.Height * _zoomfactor);
                PicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        /// <summary>
        /// Make the PictureBox dimensions smaller to effect the Zoom.
        /// </summary>
        /// <remarks>Minimum 5 times smaller</remarks>
        private void ZoomOut()
        {
            if ((PicBox.Width > (OuterPanel.Width / _minmax)) &&
                (PicBox.Height > (OuterPanel.Height / _minmax)))
            {

                PicBox.Width = Convert.ToInt32(PicBox.Width / _zoomfactor);
                PicBox.Height = Convert.ToInt32(PicBox.Height / _zoomfactor);
                PicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        #endregion

        #region MousePictureBoxHandler

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                _size = new Size(Math.Abs(_point.X - e.Location.X), Math.Abs(_point.Y - e.Location.Y));
                PicBox.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            _size = new Size(Math.Abs(_point.X - e.Location.X), Math.Abs(_point.Y - e.Location.Y));
            PicBox.Invalidate();

            var tmpPoint = _point;
            var tmpSize = _size;
            Crop_Release();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Red, 2);
            e.Graphics.DrawRectangle(pen, _point.X, _point.Y, _size.Width, _size.Height);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            //point = new Point((int)X.Value, (int)Y.Value);
            //size = new Size((int)Width.Value, (int)Height.Value);
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            _cropedImages.Clear();
            pictureBox1.Image = null;
            _isMouseDown = true;
            _point = e.Location;
        }
        #endregion

        #region New Rezizer teste


        private const int Boxwidth = 450;
        public static Bitmap Foo(Bitmap image, int boxwidth = 450)
        {
            Bitmap imagedone;
            try
            {
                Bitmap original = image;
                //Bitmap original = LoadOriginalImage(cfilename);

                if (ImageIsBox(original))
                    return new Bitmap(original, boxwidth, boxwidth);

                var newDimensions = CalculateNewDimensionsForImage(original);
                imagedone = new Bitmap(original, newDimensions.Width, newDimensions.Height);

                return imagedone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public class ImageDimensions
        {
            public int Height { get; set; }
            public int Width { get; set; }
        }
        private static bool ImageIsBox(Bitmap original)
        {
            return original.Height == original.Width;
        }
        private static Bitmap LoadOriginalImage(string imagePath)
        {
            using (FileStream fs = new FileStream(imagePath, FileMode.Open))
            {
                return new Bitmap(fs);
            }
        }
        private static ImageDimensions CalculateNewDimensionsForImage(Bitmap original)
        {
            //calculate aspect ratio
            float aspect = original.Width / (float)original.Height;
            int newWidth, newHeight;

            //calculate new dimensions based on aspect ratio
            newWidth = (int)(Boxwidth * aspect);
            newHeight = (int)(newWidth / aspect);

            //if one of the two dimensions exceed the box dimensions
            if (newWidth > Boxwidth || newHeight > Boxwidth)
            {
                //depending on which of the two exceeds the box dimensions set it as the box dimension and calculate the other one based on the aspect ratio
                if (newWidth > newHeight)
                {
                    newWidth = Boxwidth;
                    newHeight = (int)(newWidth / aspect);
                }
                else
                {
                    newHeight = Boxwidth;
                    newWidth = (int)(newHeight * aspect);
                }
            }

            return new ImageDimensions()
            {
                Height = newHeight,
                Width = newWidth
            };
        }
        #endregion
        private void button5_Click(object sender, EventArgs e)
        {
            ParentPanel.Controls.Clear();
            ParentPanel.Hide();
        }
    }
}
