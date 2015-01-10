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

        static BitmapImage imgWoods = new BitmapImage(new Uri("pack://application:,,,/textures/woods.png", UriKind.RelativeOrAbsolute));
        static BitmapImage imgMountains = new BitmapImage(new Uri("pack://application:,,,/textures/mountain.png", UriKind.RelativeOrAbsolute));
        static BitmapImage imgPlain = new BitmapImage(new Uri("pack://application:,,,/textures/plain.png", UriKind.RelativeOrAbsolute));
        static BitmapImage imgDesert = new BitmapImage(new Uri("pack://application:,,,/textures/desert.png", UriKind.RelativeOrAbsolute));



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

        /**
         * \brief show units on this hexagon
         */
        private void hex_down(object sender, MouseButtonEventArgs e)
        {
            List<Unit> unitsHere = PageGame.getUnitsOn(this.coord);
            if (unitsHere.Count == 0)
            {
                return;
            }
            string resul = "Units on hexagon ("+this.coord.x+","+this.coord.y+") :\n";
            foreach (Unit unit in unitsHere)
            {
                resul += unit.faction+" : Helth Points = "+unit.currentHP+"/"+unit.maxHP+" - MovPoints = "+unit.movementPoints+"\n";
            }
            MessageBox.Show(resul);
            
        }



        public void SetWoods()
        {
            this.fond.ImageSource = imgWoods;
        }

        public void SetMountain()
        {
            this.fond.ImageSource = imgMountains;

        }

        public void SetPlain()
        {
            this.fond.ImageSource = imgPlain;

        }

        public void SetDesert()
        {
            this.fond.ImageSource = imgDesert;

        }

        private void mouseEnter(object sender, MouseEventArgs e)
        {
            this.PolygonTile.Stroke = new SolidColorBrush(Colors.White);
        }

        private void PolygonTile_MouseLeave(object sender, MouseEventArgs e)
        {
            this.PolygonTile.Stroke = new SolidColorBrush(Colors.Black);
        }

  
    }
}