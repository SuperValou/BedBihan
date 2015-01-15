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

        public static Game game;
        private Hex selectedHex = null;
        private MainWindow parent;
        private UnitTexture selectedUnit  = null;

        public static List<Hex> hexagons = new List<Hex>();
        public static List<UnitTexture> unitsInGame = new List<UnitTexture>();


        public PageGame()
        {
            InitializeComponent();
            parent = (Application.Current.MainWindow as MainWindow);
            game = parent.game;
            Coordinates.mapSize = game.board.b_size;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadPanels();
            PrintMap();
            placeTroops();
            displayUnits();
        }

        /*
         * \ref load the panel displaying unit status and controls
         * */
        private void loadPanels()
        {
            parent.controlUnitBackground.Visibility = System.Windows.Visibility.Visible;
            parent.moveUnitButton.Visibility = System.Windows.Visibility.Visible;
            parent.movPoints.Visibility = System.Windows.Visibility.Visible;
            parent.unitIcon.Visibility = System.Windows.Visibility.Visible;
        }


        /**
         * \brief build the map (all hexagons textures)
         */
        private void PrintMap()
        {
            int taille = game.board.b_size;

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
                        h.pg = this;
                        h.coord = new Coordinates(nbC, nbR);
                        Grid.SetColumn(h, nbC);
                        row.Children.Add(h);
                        hexagons.Add(h);

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
                        h.pg = this;
                        h.coord = new Coordinates(nbC - 1, nbR);
                        Grid.SetColumn(h, nbC);
                        row.Children.Add(h);
                        hexagons.Add(h);
                    }

                }

                Grid.SetRow(row, nbR);
                this.map.Children.Add(row);


            }
            initHexImg();
        }

        /**
         * \brief set all hexagons background
         */
        private void initHexImg()
        {
            Hexagon[,] board = game.board.grid;

            foreach (Grid row in this.map.Children)
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
            for (int i = 0; i < game.list_players.Count; i++)
            {
                Coordinates coord = new Coordinates(positions[i][0], positions[i][1]);

                for (int j = 0; j < game.list_players[i].faction.troops.Length; j++)
                {
                    game.list_players[i].faction.troops[j].coordinates = coord;
                }
            }
        }


        /**
         * \brief display all units on the map
         */
        private void displayUnits()
        {
            foreach (Player player in game.list_players)
            {
                foreach (Unit unit in player.faction.troops)
                {
                    UnitTexture unitTexture = new UnitTexture(unit);
                    unitsInGame.Add(unitTexture);
                    displayUnitOnMap(unitTexture);
                }
            }
        }

        
        /**
         * \brief display a unit on the map
         */
        private void displayUnitOnMap(UnitTexture unitTexture)
        {
            int x = unitTexture.unit.coordinates.x;
            int y = unitTexture.unit.coordinates.y;

            // if odd row
            if (y % 2 != 0)
            {
                x++;
            }

            Grid SelectedRow = (Grid)VisualTreeHelper.GetChild(this.map, y);

            Grid.SetColumn(unitTexture, x);
            
            SelectedRow.Children.Add(unitTexture);
        }

        

        private void RemoveUnitOnMap(UnitTexture unitTexture)
        {
            int x = unitTexture.unit.coordinates.x;
            int y = unitTexture.unit.coordinates.y;

            // if odd row
            if (y % 2 != 0)
            {
                x++;
            }

            Grid SelectedRow = (Grid)VisualTreeHelper.GetChild(this.map, y);
  
            SelectedRow.Children.Remove(unitTexture);
            // VisualTreeHelper.GetChild(SelectedRow, x).
            

            
        }



        /*
         * \brief return the list of the unit on the specified coordinates
         * */
        internal static List<UnitTexture> getUnitsOn(Coordinates coordinates)
        {
            List<UnitTexture> units = new List<UnitTexture>();
            foreach (UnitTexture unitTex in unitsInGame)
            {
                if (unitTex.unit.coordinates.x == coordinates.x && unitTex.unit.coordinates.y == coordinates.y)
                {
                    units.Add(unitTex);
                }
                
            }
            return units;
        }

        /*
         * \brief 
         * */
        public void selectHex(Hex h, List<UnitTexture> ListUnit)
        {
            // debug
            // show coordinates of the clicked hexagon
            // debug

            if (h != this.selectedHex)
            {
                if (selectedHex != null)
                {
                    parent.infoUnit.Children.Clear();
                    selectedHex.deselect();
                }
                selectedHex = h;
                foreach (UnitTexture uTex in ListUnit)
                {
                    UnitScore us = new UnitScore(uTex);
                    us.pg = this;
                    uTex.unitscore = us;
                    parent.infoUnit.Children.Add(us);
                }
                if (ListUnit.Count > 0)
                {
                    selectUnit(ListUnit.First<UnitTexture>());
                }
                else
                {
                    deselectEverything();
                }

            }

        }

        /*
         * \brief show unit statistics and highlight accessible hexagons
         * */
        internal void selectUnit(UnitTexture unitTex)
        {
            highlightAccessibleHexagons(unitTex);
            this.selectedUnit = unitTex;

            foreach (UnitScore unitScore in parent.infoUnit.Children)
            {
                unitScore.unselect();
            }

            // update the control panel
            unitTex.unitscore.select();
            parent.unitIcon.Source = new BitmapImage(new Uri("pack://application:,,,/textures/" + unitTex.unit.faction + ".png", UriKind.RelativeOrAbsolute));
            parent.unitIcon.Visibility = Visibility.Visible;
            parent.unitName.Content = "Beautiful unit";
            parent.movementPoints.Content = unitTex.unit.movementPoints;
      
        }

        /*
         * \brief highlight the accessible hexagons for the specified unit
         * */
        private void highlightAccessibleHexagons(UnitTexture unitTex)
        {
            // highlight accessible hexagons
            List<Coordinates> adjacent = unitTex.unit.coordinates.getAdjacent();
            //string res = " x " + adjacent.First<Coordinates>().x + "y : " +  adjacent.First<Coordinates>().y;
            //MessageBoxResult mg = MessageBox.Show(res);
            deselectEverything();

            foreach (Coordinates coord in adjacent)
            {
            
                // if korrigan, highlight mountains too
                if (unitTex.unit.faction == Faction.korrigan)
                {
                    foreach (Hex hex in hexagons)
                    {
                        if (hex.field == Field.Mountain || (hex.coord.x == coord.x && hex.coord.y == coord.y))
                        {
                            hex.highlight();

                        }
                    }
                }

                // else just highlight accessible hexagons
                else
                {
                    foreach (Hex hex in hexagons)
                    {
                        if (hex.coord.x == coord.x && hex.coord.y == coord.y)
                        {
                            hex.highlight();

                        }
                    }
                }
            }
            
        }


        /*
         * \brief  deselect the current unit and reset the control panel
         * */
        internal void deselectEverything()
        {
            parent.unitIcon.Visibility = Visibility.Hidden;
            foreach(Hex hex in hexagons)
            {
                hex.deselect();
            }
        }



        public void moveUnit(Coordinates coord)
        {

            this.RemoveUnitOnMap(this.selectedUnit);
            this.selectedUnit.unit.coordinates = coord;
            displayUnitOnMap(this.selectedUnit);
        }
    



    }
}

