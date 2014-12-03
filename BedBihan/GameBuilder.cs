using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class GameBuilder
    {

        protected Game game
        {
            get;
            set;
        }


        public Game getGame()
        {
            return this.game;
        }

        public void createNewGame()
        {
            this.game = new Game();
        }

        public abstract void buildBoard();
        public abstract void buildMaxTurnNumber();
        public abstract void buildCurrentTurn();
        public abstract void buildList_players();

        

    }
}
