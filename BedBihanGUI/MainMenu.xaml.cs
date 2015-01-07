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

namespace BedBihanGUI
{
    /// <summary>
    /// Logique d'interaction pour MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private MainWindow parent;


         

        public MainMenu()
        {
            InitializeComponent();
            parent = (Application.Current.MainWindow as MainWindow);

        }

        private void LunchGame(object sender, RoutedEventArgs e)
        {

            parent.MainMenu.Source = new Uri("PageGame.xaml", UriKind.Relative);
             
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
          //  MessageBoxResult result = MessageBox.Show(Tbp1.Text);   
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

     
    }
}
