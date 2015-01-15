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
    /// Logique d'interaction pour score.xaml
    /// </summary>
    public partial class score : Page
    {

        Player j;
        public score(Player J)
        {
            InitializeComponent();
            this.Name.Content = J.name;
            this.j = J;
            poke();
            
        }

        public void poke()
        {
            this.ScoreValue.Content = j.points;
        }
    }
}
