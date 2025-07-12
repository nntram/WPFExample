using System;
using System.Windows;


namespace WPFExample1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
        }

        private void ButtonStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelExample ex1 = new StackPanelExample();
            this.Hide();

            // When second window closes, show this window again
            ex1.Closed += (s, args) => this.Show();

            ex1.Show();
        }

        private void ButtonGrid_Click(object sender, RoutedEventArgs e)
        {
            GridExample ex2 = new GridExample();
            this.Hide();

            // When second window closes, show this window again
            ex2.Closed += (s, args) => this.Show();

            ex2.Show();
        }

        private void ButtonWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelExample ex3 = new WrapPanelExample();
            this.Hide();

            // When second window closes, show this window again
            ex3.Closed += (s, args) => this.Show();

            ex3.Show();
        }
    }
}
