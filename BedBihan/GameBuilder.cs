using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public abstract class GameBuilder
    {

  

        public Game game
        {
            get;
            protected set;
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
        public abstract void buildList_players(string pj1,string pj2);

        

    }
}
