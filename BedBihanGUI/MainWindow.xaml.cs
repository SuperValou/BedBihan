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
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Threading;

namespace BedBihanGUI
{ 
    
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<score> listScore;
        public Game game;

        public MainWindow()
        {
            InitializeComponent();
            listScore = new List<score>();
                       
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
            this.movPoints.Visibility = System.Windows.Visibility.Visible;
            this.movementPoints.Visibility = System.Windows.Visibility.Visible;
            this.unitIcon.Visibility = System.Windows.Visibility.Visible;
            this.playerLabel.Visibility = System.Windows.Visibility.Visible;
            this.turnLabel.Visibility = System.Windows.Visibility.Visible;
            this.endTurnButton.Visibility = System.Windows.Visibility.Visible;
            this.updateTurnPanel();
            this.maxTurnNumber.Visibility = System.Windows.Visibility.Visible;
            this.currentPlayer.Visibility = System.Windows.Visibility.Visible;
            this.currentTurn.Visibility = System.Windows.Visibility.Visible;
            this.newgame.Visibility = System.Windows.Visibility.Visible;
        }

        public void RemovePanels()
        {
            this.controlUnitBackground.Visibility = System.Windows.Visibility.Hidden;
            this.movPoints.Visibility = System.Windows.Visibility.Hidden;
            this.movementPoints.Visibility = System.Windows.Visibility.Hidden;
            this.unitIcon.Visibility = System.Windows.Visibility.Hidden;
            this.playerLabel.Visibility = System.Windows.Visibility.Hidden;
            this.turnLabel.Visibility = System.Windows.Visibility.Hidden;
            this.endTurnButton.Visibility = System.Windows.Visibility.Hidden;
            this.maxTurnNumber.Visibility = System.Windows.Visibility.Hidden;
            this.currentPlayer.Visibility = System.Windows.Visibility.Hidden;
            this.currentTurn.Visibility = System.Windows.Visibility.Hidden;
            this.newgame.Visibility = System.Windows.Visibility.Hidden;
        }

        /*
         * \brief end the turn of the current player
         * */
        private void endTurn(object sender, RoutedEventArgs e)
        {
            if(game.over() || this.currentTurn == this.maxTurnNumber)
            {
                string winner = game.getWinner().name;
                MessageBox.Show(winner + " WIN ! ");
                this.newgame_Click(null,null);
            }
            if (game.currentPlayer == game.list_players.Last<Player>())
            {
                game.currentTurn++;
                game.currentPlayer = game.list_players.First<Player>();
                updateTurnPanel();
            }
            else
            {
                // Don't work with more than two player
                game.currentPlayer = game.list_players.Last<Player>();
                updateTurnPanel();
            }

            game.endTurn();
            string msg = game.currentPlayer.name + "'s turn !";
            DisplayPlayerTurn(msg);
            game.updatePoint();
            foreach(score s in listScore)
            {
                s.poke();
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
       // public void updateScores()
       // {
       //     foreach (Player p in game.list_players)
       //     {
       //         int score = 0;
       //         foreach (Unit u in p.faction.troops)
       //         {
       //             score += u.getPoints();
       //         }
                
       //     }
            
       //}

        public void DisplayPlayerTurn(string s) 
        {
            this.PlayerTurn.Text = s;
            Storyboard sb = this.FindResource("fadeIn") as Storyboard;
            Storyboard.SetTarget(sb, this.PlayerTurn);
            Storyboard sbSize = this.FindResource("SizeOn") as Storyboard;
            Storyboard.SetTarget(sbSize, this.PlayerTurn);
            
            sb.Begin();
            sbSize.Begin();
        }

        public void newgame_Click(object sender, RoutedEventArgs e)
        {
            this.ScoreJ1.Visibility = Visibility.Hidden;
            this.ScoreJ2.Visibility = Visibility.Hidden;
            MainMenu m = new MainMenu();
            this.RemovePanels();
            this.center.Navigate(m);
        }

        




       
    }
}
