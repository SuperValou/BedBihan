using BedBihan;
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
        // unit associated to the texture
        public Unit unit
        {
            get;
            set;
        }

        // unitscore associated
        public UnitScore unitscore
        {
            get;
            set;
        }

        public UnitTexture()
        {
            InitializeComponent();
        }

        /**
         * \brief initialize a unit texture 
         */
        public UnitTexture(Unit unit)
        {
            this.unit = unit;
            InitializeComponent();
            this.background.ImageSource = new BitmapImage(new Uri("pack://application:,,,/textures/"+this.unit.faction+".png", UriKind.RelativeOrAbsolute));
        }

        
    }
}
