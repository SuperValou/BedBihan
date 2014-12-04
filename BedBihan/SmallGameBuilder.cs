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

        public override void buildList_players(string pj1,string pj2)
        {
            List<Player> lplay = new List<Player>();
            Player j1 = new Player(6,pj1);
            Player j2 = new Player(6,pj2);
            lplay.Add(j1);
            lplay.Add(j2);
            this.game.setListplayers(lplay);
        }


        public override void buildMaxTurnNumber()
        {
            this.game.setMaxTurnNumber(20);
        }
    }
}
