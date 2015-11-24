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
            temp = players[playerNum];
            System.Console.WriteLine("This is player "+(playerNum+1));
            System.Console.WriteLine(players[playerNum].playerBase);

            System.Console.WriteLine("Show next player?");
            string choice;
            choice = System.Console.ReadLine();
            int cho;
            int.TryParse(choice, out cho);
            if (choice == "yes")
                return (playerNum + 1) % 2;
            else
                return playerNum;


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
    }
}
