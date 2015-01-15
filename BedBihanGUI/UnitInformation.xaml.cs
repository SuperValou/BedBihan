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
    /// Logique d'interaction pour UnitInformation.xaml
    /// </summary>
    public partial class UnitInformation : UserControl
    {
        public UnitInformation(Unit u)
        {
            InitializeComponent();
            this.unitIcon.Source = new BitmapImage(new Uri("pack://application:,,,/textures/" + u.faction + ".png", UriKind.RelativeOrAbsolute));
            this.unitName.Content = u.faction;
            this.movementPoints.Content = u.movementPoints;
            this.HP.Content = u.currentHP;
            this.Att.Content = u.attack;
            this.def.Content = u.defense;
            this.Att.Visibility = Visibility.Visible;
            this.def.Visibility = Visibility.Visible;
            this.movementPoints.Visibility = Visibility.Visible;
            this.EnUnit.Visibility = Visibility.Hidden;
            this.AttaqueLabel.Visibility = Visibility.Visible;
            this.DefenceLabel.Visibility = Visibility.Visible;
            this.lifeLabel.Visibility = Visibility.Visible;
        }

        public UnitInformation(List<UnitTexture> Lu)
        {
            InitializeComponent();
            Faction f = Lu.First<UnitTexture>().unit.faction;
            this.unitIcon.Source = new BitmapImage(new Uri("pack://application:,,,/textures/" + f + ".png", UriKind.RelativeOrAbsolute));

            this.AttaqueLabel.Visibility = Visibility.Hidden;
            this.DefenceLabel.Visibility = Visibility.Hidden;
            this.lifeLabel.Visibility = Visibility.Hidden;
            this.Att.Visibility = Visibility.Hidden;
            this.def.Visibility = Visibility.Hidden;
            this.movementPoints.Visibility = Visibility.Hidden;
            this.unitName.Content = Lu.Count + " " + f;
            this.EnUnit.Visibility = Visibility.Visible;
            this.HP.Visibility = Visibility.Hidden;
            this.movPoint.Visibility = Visibility.Hidden;
        }

        
    }
}
