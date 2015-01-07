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
    /// Interaction logic for UnitTexture.xaml
    /// </summary>
    public partial class UnitTexture : UserControl
    {
        public UnitTexture()
        {
            InitializeComponent();
        }

        /**
         * \brief initialize a unit texture 
         */
        public UnitTexture(BedBihan.Faction faction)
        {
            InitializeComponent();
            this.background.ImageSource = new BitmapImage(new Uri("pack://application:,,,/textures/"+faction+".png", UriKind.RelativeOrAbsolute));
        }

        /**
         * \brief do something when you click on the unit
         */
        private void unitOnClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("ta cliké sur 1 unité bravo sal batar");
        }
    }
}
