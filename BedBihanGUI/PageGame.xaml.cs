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

            game = parent.game;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PrintMap();
            placeTroops();
            displayUnits();
        }


        

        /**
         * \brief display the map (all hexagons)
         */
        private void PrintMap()
        {
           int taille = this.game.board.b_size;
           
            for (int nbR = 0; nbR < taille; nbR++)
            {
                this.map.RowDefinitions.Add(new RowDefinition());
                Grid row = new Grid();
                row.HorizontalAlignment = HorizontalAlignment.Stretch;
                row.VerticalAlignment = VerticalAlignment.Stretch;
              
                Rectangle Rempty = new Rectangle();
                Rempty.Width = 51;
                Rempty.Height = 50;

 
                if (nbR % 2 == 0)
                {
                    for (int nbC = 0; nbC < taille; nbC++)
                    {
                        row.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(2, GridUnitType.Star) });
                        Hex h = new Hex();
                        h.coord = new Coordinates(nbR, nbC);
                        Grid.SetColumn(h, nbC);
                        row.Children.Add(h);

                    }

                    row.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                  
                    Grid.SetColumn(Rempty, taille);
                    row.Children.Add(Rempty);
            
                }

                else
                {
                    row.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                //    r.Fill = mySolidColorBrush;
                    Grid.SetColumn(Rempty, 0);

                    row.Children.Add(Rempty);
                   

                    for (int nbC = 1; nbC < taille + 1; nbC++)
                    {
                        row.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(2, GridUnitType.Star) });
                        Hex h = new Hex();
                        h.coord = new Coordinates(nbR, nbC-1);
                        Grid.SetColumn(h, nbC);
                        row.Children.Add(h);
                    }

                }

                Grid.SetRow(row, nbR);
                this.map.Children.Add(row);


            }

           

            initHexImg();
        }

        /**
         * \brief display an hexagon
         */
        private void initHexImg()
        {
            Hexagon[,] board = this.game.board.grid;

            foreach(Grid row in this.map.Children)
            {
                foreach (Object o in row.Children)
                {
                    if (o is Hex)
                    {
                        Hex h = (Hex)o;
                        int x = h.coord.x;
                        int y = h.coord.y;
                        PrintFondHex(board[x, y], h);
                    }
                }
            }

        }

        /**
         * \brief set hexagon background
         */
        private void PrintFondHex(Hexagon hexLog, Hex hexPhys)
        {
            if (hexLog is Woods)
            {
                hexPhys.SetWoods();
            }
            else if (hexLog is Plain) 
            {
                hexPhys.SetPlain();
            }
            else if (hexLog is Mountain)
            {
                hexPhys.SetMountain();
            }
            else if (hexLog is Desert)
            {
                hexPhys.SetDesert();
            }

        }


        /**
        * \brief set the position of the opposing troops
        */
        private unsafe void placeTroops()
        {
            
            int** positions = WrapperGate.access.getStartingPositions(game.list_players.Count, game.board.b_size);
            for (int i = 0; i < game.list_players.Count;i++ )
            {
                Coordinates coord = new Coordinates(positions[i][0], positions[i][1]);

                for (int j = 0; j < this.game.list_players[i].faction.troops.Length; j++)
                {
                    this.game.list_players[i].faction.troops[j].coordinates = coord;
                }
            }
        }


        /**
         * \brief display all units on the map
         */
        private void displayUnits()
        {
            foreach (Player player in this.game.list_players)
            {
                foreach (Unit unit in player.faction.troops)
                {
                    displayUnitOnMap(unit);
                }
            }
        }

       


        /**
         * \brief display a unit on the map
         */
        private void displayUnitOnMap(Unit unit)
        {
            UnitTexture unitTexture = new UnitTexture(unit.faction);
            this.map.Children.Add(unitTexture);
            
            // this.map.Children.Cast<UIElement>().First(e => Grid.GetRow(e) == unit.coordinates.x && Grid.GetColumn(e) == unit.coordinates.y);
        }




    }

}

