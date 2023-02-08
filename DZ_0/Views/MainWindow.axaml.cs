using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace DZ_0.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void KhakiClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.Khaki;
        }
        private void RedClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.Red;
        }
        private void MediumVioletRedClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.MediumVioletRed;
        }
        private void BisqueClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.Bisque;
        }
        private void LemonChiffonClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.LemonChiffon;
        }
        private void PowderBlueClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.PowderBlue;
        }
        private void MintCreamClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.MintCream;
        }
        private void MaroonClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.Maroon;
        }
        private void RosyBrownClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.RosyBrown;
        }
        private void LightPinkClick(object sender, RoutedEventArgs e)
        {
            Fig.Fill = Brushes.LightPink;
        }
    }
}
