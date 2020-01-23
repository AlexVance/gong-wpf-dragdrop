using System.Windows;

namespace WrapPanelInsertIndexIssue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Vm = new MainViewModel();

            DataContext = Vm;
        }

        public MainViewModel Vm { get; set; }
    }
}
