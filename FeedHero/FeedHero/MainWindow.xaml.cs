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

namespace FeedHero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Uri ur = new Uri("pack://application:,,,/Resources/House.png");
        static List<Button> MenuButtons = new List<Button>();

        public MainWindow()
        {
            InitializeComponent();
            MenuButtons.Add(bBuildHouse);
            MenuButtons.Add(bPlantTree);
            bBuildHouse.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
        }

        private void bEnvironment_Click(object sender, RoutedEventArgs e)
        {
            
            BitmapImage img = new BitmapImage(ur);
            Button s = (Button)sender;
            Image i= (Image)s.Content;
            i.Source = img;
        }

        private void bPlantTree_Click(object sender, RoutedEventArgs e)
        {
            ur = new Uri("pack://application:,,,/Resources/Tree.png");
            foreach (Button b in MenuButtons)
            {
                b.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            }
            bPlantTree.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
        }

        private void bBuildHouse_Click(object sender, RoutedEventArgs e)
        {
            ur = new Uri("pack://application:,,,/Resources/House.png");
            foreach(Button b in MenuButtons)
            {
                b.Background= new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            }
            bBuildHouse.Background= new SolidColorBrush(Color.FromArgb(255,0,0,255));
        }
    }
}
