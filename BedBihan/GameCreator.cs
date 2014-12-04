using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public class GameCreator
    {

        private string pj1;
        private string pj2;

        public GameBuilder gameBuilder
        {
            get;
            set;
        }

        public Game getGame(){
            return gameBuilder.getGame();
        }

        // TODO : change to list.add to manage more than 2 players
        public void setPeopleJ1(string pj)
        {
            pj1 = pj;
        }

        public void setPeopleJ2(string pj)
        {
            pj2 = pj;
        }

        public void createGame()
        {
            gameBuilder.createNewGame();
            gameBuilder.buildBoard();
            gameBuilder.buildMaxTurnNumber();
            gameBuilder.buildList_players(pj1,pj2);
        }


    }
}
