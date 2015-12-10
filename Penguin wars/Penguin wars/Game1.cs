using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin_wars
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;

        player[] players = new player[2];
        int turnCounter = -1;
        Random rand = new Random();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        //protected override void BeginRun()
        //{
        //    playfield.doTurn();
        //    base.BeginRun();
        //}

        Vector2 fontPos;

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        /// 
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //font = Content.Load<SpriteFont>("Arial");

            //fontPos = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2);


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            startGame();
            base.Update(gameTime);
        }

        public void startGame()
        {
            players[0] = new player();
            players[1] = new player();

            int playerTurn = 0;
            while (!Keyboard.GetState().IsKeyDown(Keys.Escape))
                playerTurn = startTurn(playerTurn);
            System.Console.WriteLine("We're done");
            Exit();

        }

        
        player temp;
        public int startTurn(int playerNum)
        {
            if (playerNum == 0)
                turnCounter++;
            if (turnCounter != 0 && (turnCounter % 4 == 0))
                skirmish();

           temp = players[playerNum];

            //To-do: get player input, tie this to game methods, etc
            

                return (playerNum + 1) % 2;
        }

        private int[] gatherIntel(int player)
        {
            int[] result = new int[11];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }


            if (players[player].snowmenSpies > 0)
            {
                for(int i=0; i<result.Length-1; i++)
                {
                    result[i] = players[(player + 1) % 2].playerBase.buildings[i].level;
                }
                result[10] = players[(player + 1) % 2].playerBase.superSnowball.level;

                players[player].snowmenSpies--;
            }

            else
                Console.WriteLine("You don't have enough spies");

            return result;
        }

        private int skirmish()
        {
            float p1Strength = players[0].skirmishStrengh * players[0].armySize;
            float p2Strength = players[0].skirmishStrengh * players[0].armySize;
            float difference = Math.Abs(p1Strength - p2Strength);
            int winner;

            if(p1Strength == p2Strength)
            {
                winner = rand.Next(0, 2);
                difference = .1f;
            }
            else if(p1Strength > p2Strength){
                winner = 0;
            }
            else
            {
                winner = 1;
            }

            players[winner].reduceStrength(difference);
            players[(winner + 1) % 2].reduceStrength(difference * 1.5f);

            return winner;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);
            //spriteBatch.Begin();

            //string output = "Hello world";

            //Vector2 fontOrigin = font.MeasureString(output) / 2;
            //spriteBatch.DrawString(font, output, fontPos, Color.LightGreen, 0, fontOrigin, 1.0f, SpriteEffects.None, .5f);

            // TODO: Add your drawing code here

            //base.Draw(gameTime);
        }


        public void debugStartGame() //Used to make sure that skirmish is fair. Results: Generally each player has a more or less equal chance to win a skirmish without upgrading
        {
            players[0] = new player();
            players[1] = new player();

            int wins1 = 0;
            int wins2 = 0;
            int winner = -1;

            int totalP1Win = 0;
            int totalP2win = 0;

            for (int i = 0; i < 10; i++)
            {
                players[0] = new player();
                players[1] = new player();

                wins1 = 0;
                wins2 = 0;

                while (wins1 < 4 && wins2 < 4)
                {
                    winner = skirmish();
                    if (winner == 0)
                        wins1++;
                    else
                        wins2++;
                }
                Console.WriteLine("P1 strength: " + players[0].skirmishStrengh + "|" + players[0].armySize + "\tP2 strength: " + players[1].skirmishStrengh + "|" + players[1].armySize);

                if (wins1 > wins2)
                    totalP1Win++;
                else
                    totalP2win++;
            }
            Console.WriteLine("P1 wins: " + totalP1Win + "\tP2 wins: " + totalP2win);



            int playerTurn = 0;
            while (!Keyboard.GetState().IsKeyDown(Keys.Escape))
                playerTurn = startTurn(playerTurn);
            System.Console.WriteLine("We're done");
            Exit();

        }
    }
}
