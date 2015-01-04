﻿using System;
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
            GameBuilder gb = new SmallGameBuilder();
            gc.gameBuilder = gb;
            gc.createGame();
            game = gc.getGame();
            
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PrintMap();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.grid.Height = Double.NaN; // set to "auto" 

        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        /*    UIElementCollection lcase = this.LayoutRoot.Children;
            foreach(Hex tile in lcase){
                tile.Height = 20;*/
            }

     
        private void PrintMap()
        {

           
           int taille = this.game.board.b_size;
            

            for (int nbR = 0; nbR < taille; nbR++)
            {
                this.map.BoardGrid.RowDefinitions.Add(new RowDefinition());
                Grid row = new Grid();
                SolidColorBrush mySolidColorBrush = new SolidColorBrush(Color.FromRgb(111, 111, 111));

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
                  
            
                }

                else
                {
                    row.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                   

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
                this.map.BoardGrid.Children.Add(row);


            }

            Grid LastRow = new Grid();
            Grid.SetRow(LastRow, taille);
            //this.map.BoardGrid.Children.Add(LastRow);

            initHexImg();
        }


        private void initHexImg()
        {
            Hexagon[,] board = this.game.board.grid;

            foreach(Grid row in this.map.BoardGrid.Children)
            {
                foreach (Hex h in row.Children)
                {
                    int x = h.coord.x;
                    int y = h.coord.y;
                    PrintFondHex(board[x, y], h);
                }
            }

        }

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





    }

}

