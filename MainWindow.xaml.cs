using Potter.API;
using Potter.API.Interfaces;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiNIPotter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BooksViewModel ViewModel { get; }
        public MainWindow()
        {
            InitializeComponent();
            IBooksRepository repository = new BooksRepository();
            DataContext = new BooksViewModel(repository);
        }

        private async void LoadBooks_Click(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadBooksAsync();
        }
    }
}