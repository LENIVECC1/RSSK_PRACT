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

namespace RSSK_PRACT
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



        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ABOUT_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dd");
        }

        public void SUMMA_Click(object sender, RoutedEventArgs e)
        {
            REZ.Clear();
            if (double.TryParse(TEXT1.Text, out double a) && double.TryParse(TEXT2.Text, out double b))
            {
                double c = raschet.sum(a,b);
                REZ.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        public void UMN_Click(object sender, RoutedEventArgs e)
        {
            REZ.Clear();
            if (double.TryParse(TEXT1.Text, out double a) && double.TryParse(TEXT2.Text, out double b))
            {
                double c = raschet.umn(a,b);
                REZ.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        public void DELEN_Click(object sender, RoutedEventArgs e)
        {
            REZ.Clear();
            if (double.TryParse(TEXT1.Text, out double a) && double.TryParse(TEXT2.Text, out double b))
            {
                double c = raschet.del(a, b);
                REZ.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void CLEAR_Click(object sender, RoutedEventArgs e)
        {
            REZ.Text = null;
            TEXT1.Text = null;
            TEXT2.Text = null;
        }

        private void TEXT1_TextChanged(object sender, TextChangedEventArgs e)
        {
            REZ.Text = null;
        }

        private void TEXT2_TextChanged(object sender, TextChangedEventArgs e)
        {
            REZ.Text = null;
        }
    }
}