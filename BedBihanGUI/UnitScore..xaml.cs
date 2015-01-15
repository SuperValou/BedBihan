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
        UnitTexture unitTex;
        public PageGame pg
        {
            get;
            set;
        }
        public UnitScore(UnitTexture u)
        {
            InitializeComponent();
            unitTex = u;
            Race.Content = u.unit.faction.ToString();
            HP.Content = u.unit.currentHP;
           
        }

        /*
         * \brief print [selected] on the unit score to indicate that the unit is selected
         * */
        public void select()
        {
            selected.Content = "[selected]";
        }

        /*
         * \brief erase the [selected] to unselect the unit
         * */
        public void unselect()
        {
            selected.Content = "";
        }

        private void mouseDown(object sender, MouseButtonEventArgs e)
        {
            pg.selectUnit(this.unitTex);
        }
    }
}
