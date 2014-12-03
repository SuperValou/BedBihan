using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class SmallGameBuilder : GameBuilder
    {


        public override void buildBoard()
        {
            StrategyBoardSmall sbd = new StrategyBoardSmall();
            Board gameBoard = new Board(sbd);
            gameBoard.BuildBoard();
            this.game.setBoard(gameBoard);
        }

        public override void buildList_players()
        {
            List<Player> lplay = new List<Player>();
            Player j1 = new Player();
            Player j2 = new Player();
            lplay.Add(j1);
            lplay.Add(j2);
            this.game.setListplayers(lplay);
        }
    }
}
