using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin_wars
{
    class playfield
    {
        private static player[] players = new player[2];
        
        public static void doTurn()
        {
            players[0] = new player();
            players[1] = new player();


        }   

        public void startGame()
        {
            players[0] = new player();
            players[1] = new player();

            int playerTurn = 0;
            //while(!Keyboard.GetState().IsKeyDown(Keys.Escape))
                playerTurn = startTurn(playerTurn);
            //System.Console.WriteLine("We're done");
            //Exit();

        }

        player temp;
        public int startTurn(int playerNum)
        {
            temp = players[playerNum];
            System.Console.WriteLine("This is player " + (playerNum + 1));
            System.Console.WriteLine(players[playerNum].playerBase);

            System.Console.WriteLine("Show next player? \nyes");
            string choice;
            choice = System.Console.ReadLine();
            if (choice == "yes")
            return (playerNum + 1) % 2;
            else
               return playerNum;


        }
    }

   


}
