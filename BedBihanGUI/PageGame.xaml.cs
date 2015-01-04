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
using System.Threading;
using System.ComponentModel;

using BedBihan;
 
namespace BedBihanGUI
{
    /// <summary>
    /// Logique d'interaction pour PageGame.xaml
    /// </summary>
    public partial class PageGame : Page
    {

        private Game game;
        public PageGame()
        {
            InitializeComponent();
            MainWindow parent = (Application.Current.MainWindow as MainWindow);

            // création du game pour tester, a déplacer plus tard.
            GameCreator gc = new GameCreator();
            gc.setPeopleJ1("elf");
            gc.setPeopleJ2("human");
            GameBuilder gb = new DemoGameBuilder();
            gc.gameBuilder = gb;
            gc.createGame();
            game = gc.getGame();
            
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int taille = 20; // a recup automatiquement.

            for (int nbC = 0; nbC < taille; nbC++)
            {
                this.map.BoardGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int nbL = 0; nbL < taille; nbL++)
            {
                this.map.BoardGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int nbC = 0; nbC < taille; nbC++)
            {
                for (int nbR = 0; nbR < taille; nbR++)
                {
                    this.map.AddHex(nbC, nbR);
           }

            }
        }
            
           



        private void Button_Click(object sender, RoutedEventArgs e)
        {

           /* Hex tile = new Hex();
            this.LayoutRoot.Children.Add(tile);*/
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        /*    UIElementCollection lcase = this.LayoutRoot.Children;
            foreach(Hex tile in lcase){
                tile.Height = 20;*/
            }






    }

}

