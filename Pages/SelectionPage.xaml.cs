using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animals.Pages
{
    /// <summary>
    /// Логика взаимодействия для SelectionPage.xaml
    /// </summary>
    public partial class SelectionPage : Page
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnparnocop_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Frame.Navigate(new ParnocopPage());

        }

        private void BtnHishnoobrazn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Frame.Navigate(new HishnoobraznPage());
        }

        private void Rykokrilie_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Frame.Navigate(new RykokriliePage());
        }

        private void Grizyn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Frame.Navigate(new GrizynPage());
        }

        private void Nasekomozdn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Frame.Navigate(new NasekomozdnPage());
        }

        private void Vorobinoobrazn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Frame.Navigate(new VorobinoobraznPage());
        }

        private void Diatlo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Frame.Navigate(new DiatloPage());
        }
    }
}
