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
using BedBihan;

namespace BedBihanGUI
{
    /// <summary>
    /// Logique d'interaction pour Hex.xaml
    /// </summary>
    public partial class Hex : UserControl
    {
        public Hex()
        {
            InitializeComponent();
        }

        public Coordinates coord
        {
            get;
            set;
        }
        public void WoodOver(object obj, EventArgs ea)
        {
        }

        private void hex_down(object sender, MouseButtonEventArgs e)
        {
        }

        public void SetWoods()
        {
            this.fond.ImageSource = new BitmapImage(new Uri("pack://application:,,,/textures/woods.png", UriKind.RelativeOrAbsolute));

        }

        public void SetMountain()
        {
            this.fond.ImageSource = new BitmapImage(new Uri("pack://application:,,,/textures/mountain.png", UriKind.RelativeOrAbsolute));

        }

        public void SetPlain()
        {
            this.fond.ImageSource = new BitmapImage(new Uri("pack://application:,,,/textures/plain.png", UriKind.RelativeOrAbsolute));

        }

        public void SetDesert()
        {
            this.fond.ImageSource = new BitmapImage(new Uri("pack://application:,,,/textures/desert.png", UriKind.RelativeOrAbsolute));

        }

  
    }
}