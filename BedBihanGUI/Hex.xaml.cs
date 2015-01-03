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
    /// Logique d'interaction pour Hex_wood.xaml
    /// </summary>
    public partial class Hex : UserControl
    {
        public Hex()
        {
            InitializeComponent();
        }
        public void WoodOver(object obj, EventArgs ea)
        {
        }

        private void hex_down(object sender, MouseButtonEventArgs e)
        {
         //   this.fond.ImageSource = new BitmapImage(new Uri("pack://application:,,,/textures/woods.png", UriKind.RelativeOrAbsolute));
        }

  
    }
}