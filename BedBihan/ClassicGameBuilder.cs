using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class ClassicGameBuilder : GameBuilder
    {
        public override void buildBoard()
        {
            StrategyBoardClassic sbd = new StrategyBoardClassic();
            Board gameBoard = new Board(sbd);
            gameBoard.BuildBoard();
            this.game.setBoard(gameBoard);
        }

        public override void buildList_players(string pj1, string pj2)
        {
            List<Player> lplay = new List<Player>();
            Player j1 = new Player(8, pj1);
            Player j2 = new Player(8, pj2);
            lplay.Add(j1);
            lplay.Add(j2);
            this.game.setListplayers(lplay);
        }


        public override void buildMaxTurnNumber()
        {
            this.game.setMaxTurnNumber(30);
        }
    }
}
