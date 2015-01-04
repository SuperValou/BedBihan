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
    /// Logique d'interaction pour MapView.xaml
    /// </summary>
    public partial class MapView : UserControl
    {

  
        public MapView()
        {     
            InitializeComponent();

        }

        public void AddHex(int c, int r)
        {
            Hex h = new Hex();
            Grid.SetColumn(h,c);
            Grid.SetRow(h, r);
            this.BoardGrid.Children.Add(h);
         }

        private void Hex_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Hex_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

     
    }
}
