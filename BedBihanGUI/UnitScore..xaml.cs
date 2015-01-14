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
    /// Logique d'interaction pour UnitScore.xaml
    /// </summary>
    public partial class UnitScore : UserControl
    {
        Unit unit;
        public UnitScore(Unit u)
        {
            InitializeComponent();
            unit = u;
            Race.Content = u.faction.ToString();
            HP.Content = u.currentHP;
            HPMax.Content = "/ " + u.maxHP;
        }
    }
}
