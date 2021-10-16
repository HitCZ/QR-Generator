using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace QRGenerator.Infrastructure
{
    public static class BitmapToBitmapImageConverter
    {
        #region Public Methods

        public static BitmapImage Convert(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }

        #endregion Public Methods
    }
}
