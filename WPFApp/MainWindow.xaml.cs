using System.Windows;
using WPFExample1.Views;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1 ex1 = new MainWindow1();
            this.Hide();

            // When second window closes, show this window again
            ex1.Closed += (s, args) => this.Show();

            ex1.Show();   
        }
    }
}
