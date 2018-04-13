using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omu.Drawing;
using System.IO;

namespace ProjetoBasicoCindy
{
    public partial class UploaderControl : UserControl
    {
        #region Variables
        Size size = new Size();
        Point point = new Point();
        Bitmap testeimage;
        List<Bitmap> cropedImages = new List<Bitmap>();
        private string[] fileNames;
        private static string cfilename;
        List<Bitmap> images = new List<Bitmap>();
        bool isMouseDown = false;
        private Bitmap insertImage;
        int index = 0;
        #endregion

        #region Members

        
        private Container components = null;
        private string m_sPicName = "";

        #endregion

        #region Constants

        private double ZOOMFACTOR = 1.05;   // = 25% smaller or larger
        private int MINMAX = 5;             // 5 times bigger or smaller than the ctrl

        #endregion
        public UploaderControl()
        {
            InitializeComponent();
            InitCtrl();
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
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox.Location = new Point(0, 0);
            OuterPanel.Dock = DockStyle.Fill;
            //OuterPanel.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            OuterPanel.AutoScroll = true;
            OuterPanel.MouseEnter += new EventHandler(PicBox_MouseEnter);
            PicBox.MouseEnter += new EventHandler(PicBox_MouseEnter);
            OuterPanel.MouseWheel += new MouseEventHandler(PicBox_MouseWheel);
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
            images.Clear();
            cropedImages.Clear();
            var dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileNames = dlg.FileNames;
                foreach (var fileName in dlg.FileNames)
                {
                    images.Add(new Bitmap(fileName));
                    cfilename = fileName;
                    testeimage = new Bitmap(fileName);
                }
                PicBox.Image = Foo(testeimage);
                PicBox.SizeMode = PictureBoxSizeMode.AutoSize;
                



            }

        }




        #region CropHandler
        private void Crop_Release()
        {
            cropedImages.Clear();
            foreach (var image in images)
            {
                var cropedImage = new Bitmap(size.Width, size.Height);
                for (int i = 0; i < size.Width; i++)
                {
                    for (int j = 0; j < size.Height; j++)
                    {
                        cropedImage.SetPixel(i, j, image.GetPixel(i + point.X, j + point.Y));
                    }
                }
                cropedImages.Add(cropedImage);
            }
            cropedImages[0].Save(fileNames[0].Replace(".", "cr."));
            testeimage = cropedImages[0];
            pictureBox1.Image = testeimage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox2.Image = Foo(cropedImages[0]);
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
            if ((PicBox.Width < (MINMAX * OuterPanel.Width)) &&
                (PicBox.Height < (MINMAX * OuterPanel.Height)))
            {
                PicBox.Width = Convert.ToInt32(PicBox.Width * ZOOMFACTOR);
                PicBox.Height = Convert.ToInt32(PicBox.Height * ZOOMFACTOR);
                PicBox.SizeMode = PictureBoxSizeMode.AutoSize; 
            }
        }

        /// <summary>
        /// Make the PictureBox dimensions smaller to effect the Zoom.
        /// </summary>
        /// <remarks>Minimum 5 times smaller</remarks>
        private void ZoomOut()
        {
            if ((PicBox.Width > (OuterPanel.Width / MINMAX)) &&
                (PicBox.Height > (OuterPanel.Height / MINMAX)))
            {
                
                PicBox.Width = Convert.ToInt32(PicBox.Width / ZOOMFACTOR);
                PicBox.Height = Convert.ToInt32(PicBox.Height / ZOOMFACTOR);
                PicBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        #endregion

        #region MousePictureBoxHandler

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                size = new Size(Math.Abs(point.X - e.Location.X), Math.Abs(point.Y - e.Location.Y));
                PicBox.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            size = new Size(Math.Abs(point.X - e.Location.X), Math.Abs(point.Y - e.Location.Y));
            PicBox.Invalidate();

            var tmpPoint = point;
            var tmpSize = size;
            Crop_Release();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Red, 2);
            e.Graphics.DrawRectangle(pen, point.X, point.Y, size.Width, size.Height);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            //point = new Point((int)X.Value, (int)Y.Value);
            //size = new Size((int)Width.Value, (int)Height.Value);
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            cropedImages.Clear();
            pictureBox1.Image = null;
            isMouseDown = true;
            point = e.Location;
        }
        #endregion

        #region New Rezizer teste


        private const int BOXWIDTH = 450;
        public static Bitmap Foo(Bitmap image)
        {
            Bitmap imagedone;
            try
            {
                Bitmap original = image; 
                //Bitmap original = LoadOriginalImage(cfilename);

                if (ImageIsBox(original))
                    return new Bitmap(original, BOXWIDTH, BOXWIDTH);

                var newDimensions = CalculateNewDimensionsForImage(original);
                imagedone  = new Bitmap(original, newDimensions.Width, newDimensions.Height);
                
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
            newWidth = (int)(BOXWIDTH * aspect);
            newHeight = (int)(newWidth / aspect);

            //if one of the two dimensions exceed the box dimensions
            if (newWidth > BOXWIDTH || newHeight > BOXWIDTH)
            {
                //depending on which of the two exceeds the box dimensions set it as the box dimension and calculate the other one based on the aspect ratio
                if (newWidth > newHeight)
                {
                    newWidth = BOXWIDTH;
                    newHeight = (int)(newWidth / aspect);
                }
                else
                {
                    newHeight = BOXWIDTH;
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
    }
}
