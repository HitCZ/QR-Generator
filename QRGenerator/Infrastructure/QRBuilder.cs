using QRCoder;
using System.Drawing;
// ReSharper disable InconsistentNaming
namespace QRGenerator.Infrastructure
{
    public class QRBuilder
    {
        #region Fields

        private readonly QRCodeGenerator qrGenerator = new QRCodeGenerator();

        #endregion Fields

        #region Public Methods

        public Bitmap Generate(string text)
        {
            var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);

            return qrCodeImage;
        }

        #endregion Public Methods
    }
}
