using System.Drawing;

namespace ProjetoBasicoCindy
{
    internal class PictureUploadHandler
    {
        /// <summary>
        /// The first argument is the source image,
        /// the second defines the area to crop, and the third optionally specifies 
        /// the size of the target image. The third argument is only necessary if you would like
        /// to scale your image in any way. If you just want a straight-up crop, leave it empty!
        /// </summary>
        /// <param name="originalImage"></param>
        /// <param name="sourceRectangle"></param>
        /// <param name="destinationRectangle"></param>
        /// <returns></returns>
        private static Bitmap CropImage(Image originalImage, Rectangle sourceRectangle,
    Rectangle? destinationRectangle = null)
        {
            if (destinationRectangle == null)
            {
                destinationRectangle = new Rectangle(Point.Empty, sourceRectangle.Size);
            }

            var croppedImage = new Bitmap(destinationRectangle.Value.Width,
                destinationRectangle.Value.Height);
            using (var graphics = Graphics.FromImage(croppedImage))
            {
                graphics.DrawImage(originalImage, destinationRectangle.Value,
                    sourceRectangle, GraphicsUnit.Pixel);
            }
            return croppedImage;
        }


    }
}
