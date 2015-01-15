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
    /// Logique d'interaction pour MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private MainWindow parent;

        public MainMenu()
        {
            InitializeComponent();
            parent = (Application.Current.MainWindow as MainWindow);
            
        }

        private void LunchGame(object sender, RoutedEventArgs e)
        {
            GameCreator gc = new GameCreator();
            gc.setPeopleJ1(RacePlayer1.Text);
            gc.setPeopleJ2(RacePlayer2.Text);
            GameBuilder gb;
            switch (TypeOfGame.Text)
            {
                case "Demo Game":
                    gb = new DemoGameBuilder();
                    break;
                case "Small Game":
                    gb = new SmallGameBuilder();
                    break;
                case "Classic Game":
                    gb = new ClassicGameBuilder();
                    break;
                default:
                    gb = new DemoGameBuilder();
                    break;
            }
            
            gc.gameBuilder = gb;
            gc.createGame();
            parent.game = gc.getGame();

            parent.game.list_players[0].name = NamePlayer1.Text;
            parent.game.list_players[1].name = NamePlayer2.Text;

            PageGame pg = new PageGame();
            score scJ1 = new score(parent.game.list_players[0]);
            score scJ2 = new score(parent.game.list_players[1]);
            parent.center.Navigate(pg);
            parent.ScoreJ1.Navigate(scJ1);
            parent.ScoreJ2.Navigate(scJ2);
        }

        // TEST BUTTON 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(TypeOfGame.Text);   
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public string getKindOfGame(){
            return TypeOfGame.Text;
        }
     
    }
}
