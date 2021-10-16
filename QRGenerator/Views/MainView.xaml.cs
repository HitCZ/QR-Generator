using QRGenerator.ViewModels;

namespace QRGenerator.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView 
    {
        public MainViewModel ViewModel
        {
            get => DataContext as MainViewModel;
            set => DataContext = value;
        }

        public MainView()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
        }
    }
}
