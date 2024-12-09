using ZooApp.Pages;
using System.Windows;
using System.Windows.Controls;


namespace ZooApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Frame _frame;
        public MainWindow()
        {
            InitializeComponent();

            frmMain.Navigate(new MainMenuPage(frmMain));

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            frmMain.GoBack();
        }

        private void frmMain_ContentRendered(object sender, EventArgs e)
        {
            if (frmMain.CanGoBack)
            {
                btnBack.Visibility = Visibility.Visible;
            }
            else
            {
                btnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}