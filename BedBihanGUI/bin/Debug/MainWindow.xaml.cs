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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Game game;

        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void highlight(object sender, RoutedEventArgs e)
        {
            
        }

        /*
         * \ref load the panel displaying unit status and controls
         * */
        public void loadPanels()
        {
            this.controlUnitBackground.Visibility = System.Windows.Visibility.Visible;
            this.moveUnitButton.Visibility = System.Windows.Visibility.Visible;
            this.movPoints.Visibility = System.Windows.Visibility.Visible;
            this.unitIcon.Visibility = System.Windows.Visibility.Visible;
            this.playerLabel.Visibility = System.Windows.Visibility.Visible;
            this.turnLabel.Visibility = System.Windows.Visibility.Visible;

            this.updateTurnPanel();
            this.maxTurnNumber.Visibility = System.Windows.Visibility.Visible;
            this.currentPlayer.Visibility = System.Windows.Visibility.Visible;
            this.currentTurn.Visibility = System.Windows.Visibility.Visible;
        }

        /*
         * \brief end the turn of the current player
         * */
        private void endTurn(object sender, RoutedEventArgs e)
        {
            if (game.currentPlayer == game.list_players.Last<Player>())
            {
                game.currentTurn++;
                game.currentPlayer = game.list_players.First<Player>();
                updateTurnPanel();
            }
            else
            {
                // Don't play with more than two player, lol
                game.currentPlayer = game.list_players.Last<Player>();
                updateTurnPanel();
            }
        }

        /*
         * \brief update the panel showing who's playing and wich turn it is
         * */
        public void updateTurnPanel()
        {
            this.maxTurnNumber.Content = this.game.maxTurnNumber;
            this.currentPlayer.Content = this.game.currentPlayer.name;
            this.currentTurn.Content = this.game.currentTurn;
        }


    /*
     * \brief update the scores
     * */
        public void updateScores()
        {
            foreach (Player p in game.list_players)
            {
                int score = 0;
                foreach (Unit u in p.faction.troops)
                {
                    //score += u.getPoints();
                }
                ScoreJ1.Content = "SWAG";
            }
        }

        




       
    }
}
