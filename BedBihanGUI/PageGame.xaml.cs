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
using System.Threading;
using System.ComponentModel;


 
namespace BedBihanGUI
{
    /// <summary>
    /// Logique d'interaction pour PageGame.xaml
    /// </summary>
    public partial class PageGame : Page
    {
        int cpt;
        public PageGame()
        {
            InitializeComponent();
            
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Hex tile = new Hex();
            this.LayoutRoot.Children.Add(tile);
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UIElementCollection lcase = this.LayoutRoot.Children;
            foreach(Hex tile in lcase){
                tile.Height = 20;
            }
        }




    }

}

