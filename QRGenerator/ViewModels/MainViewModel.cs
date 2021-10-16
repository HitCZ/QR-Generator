using Common.Commands;
using Common.WPF;
using QRGenerator.Infrastructure;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace QRGenerator.ViewModels
{
    public class MainViewModel : NotificationObject
    {
        #region Fields

        private readonly QRBuilder qrBuilder;

        #endregion Fields

        #region Properties

        public string Text
        {
            get => GetPropertyValue<string>();
            set => SetPropertyValue(value);
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public BitmapImage QRCode
        {
            get => GetPropertyValue<BitmapImage>();
            set => SetPropertyValue(value);
        }

        public ICommand GenerateCommand
        {
            get => GetPropertyValue<ICommand>();
            set => SetPropertyValue(value);
        }

        #endregion Properties

        #region Constructor

        public MainViewModel()
        {
            qrBuilder = new QRBuilder();
            GenerateCommand = new RelayCommand(GenerateCommandExecute);
        }

        #endregion Constructor

        #region Private Methods

        private void GenerateCommandExecute()
        {
            if (Text is null)
                return;

            QRCode = BitmapToBitmapImageConverter.Convert(qrBuilder.Generate(Text));
        }

        #endregion Private Methods
    }
}
