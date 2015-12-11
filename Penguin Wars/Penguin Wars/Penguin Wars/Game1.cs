using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Penguin_Wars
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont Font1;
        Vector2 FontPos;
        int messagecycle = 0;
        Texture2D building = null;
        player[] players = new player[2];
        int turnCycle = 1;
        int playerNum = 0;
        Boolean beginningOfTurn = true;

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

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
            Font1 = Content.Load<SpriteFont>("SpriteFont1");

            FontPos = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2);

            building = Content.Load<Texture2D>(@"barrack");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            //System.Console.WriteLine("HI");
            if (beginningOfTurn == true)
            {
                //players[playerNum].playTurn();
                beginningOfTurn = false;
            }
           
            if (messagecycle == 0)
            {

                messagecycle = util.startMessageCycle(util.keyPush());
            }

            if (messagecycle == 1)
            {
                messagecycle = util.buildMessageCycle(messagecycle, util.keyPush());
            }
            else if (messagecycle == 11)
            {
                messagecycle = util.buildMessageCycle(messagecycle, util.keyPush());
            }
            else if (messagecycle == -1)
            {
                messagecycle = 5;
                // TODO: engage building
            }

            if (messagecycle == 2)
            {
                messagecycle = util.sabotageMessageCycle(messagecycle, util.keyPush());
            }
            else if (messagecycle == 21)
            {
                messagecycle = util.sabotageMessageCycle(messagecycle, util.keyPush());
            }
            else if (messagecycle == -2)
            {
                messagecycle = 5;
                // TODO: engage sabotage
            }

            if (messagecycle == 3)
            {
                messagecycle = util.sendSpyMessageCycle(messagecycle, util.keyPush());
            }
            else if (messagecycle == -3)
            {
                messagecycle = 5;
            }

            if (messagecycle == 4)
            {
                messagecycle = util.missionMessageCycle(messagecycle, util.keyPush());
            }
            else if (messagecycle == 41)
            {
                messagecycle = util.missionMessageCycle(messagecycle, util.keyPush());
            }
            else if (messagecycle == -4)
            {
                messagecycle = 5;
                beginningOfTurn = true;
                //TODO: engage mission
            }

            if (messagecycle == 5)
            {
                if (string.Compare(util.keyPush(), 0, "Enter", 0, 1, true) == 0)
                {
                    messagecycle = 0;
                    //TODO:engage player switch
                    if (playerNum == 0)
                    {
                        playerNum++;
                    }
                    else if (playerNum == 1)
                    {
                        playerNum--;
                    }
                }
            }
            base.Update(gameTime);
        }
        
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            displayPlayerTurn();
            displayResourceCount();
            displayCycleCount();



            if (messagecycle == 0)
            {
                ActionMessage();
            }

            if (messagecycle == 1)
            {
                BuildMessage();
            }
            else if (messagecycle == 11)
            {
                ConfirmMessage();
            }

            if (messagecycle == 2)
            {
                SabotageMessage();
            }
            else if (messagecycle == 21)
            {
                ConfirmMessage();
            }

            if (messagecycle == 3)
            {
                ConfirmMessage();
            }

            if (messagecycle == 4)
            {
                MissionMessage();
            }
            else if (messagecycle == 41)
            {
                ConfirmMessage();
            }

            if (messagecycle == 5)
            {
                displayNextTurn();
            }
            base.Draw(gameTime);
        }

        

        private void displayMainMessage(string message, float x, float y)
        {
            Vector2 fontplacement = new Vector2(x, y);
            spriteBatch.Begin();
            spriteBatch.DrawString(Font1, message, fontplacement, Color.Black);
            spriteBatch.End();
        }

        private void ActionMessage()
        {
            displayMainMessage("What would you like to do?(Enter the corresponding number)", 10, 350);
            displayMainMessage("1. Build/Upgrade a building", 10, 365);
            displayMainMessage("2. Sabotage the enemy player", 10, 380);
            displayMainMessage("3. Send spies to collect information", 10, 395);
            displayMainMessage("4. Send penguin troopers on mission", 10, 410);
            
        }

        private void BuildMessage()
        {
            displayMainMessage("What would you like to build/upgrade?(Hit Backspace to go back)", 10, 350);
            displayMainMessage("1. Spyforce", 10, 365);
            displayMainMessage("2. Snowman Workshop", 10, 380);
            displayMainMessage("3. Safeguards", 10, 395);
            displayMainMessage("4. Saboteuses", 10, 410);
            displayMainMessage("5. Barracks", 10, 425);
            displayMainMessage("6. Ice Forge", 10, 440);
            displayMainMessage("7. Penguarmy", 10, 455);
            displayMainMessage("8. Penguospital", 200, 365);
            displayMainMessage("9. Snowball Research Lab", 200, 380);
            displayMainMessage("0. Bank", 200, 395);
            displayMainMessage("-. Super Snowball", 200, 410);

        }

        private void SabotageMessage()
        {
            displayMainMessage("What would you like to sabotage?", 10, 350);
            displayMainMessage("1. Reduce a building's level to zero (1 fish)", 10, 365);
            displayMainMessage("2. Capture Enemy Workers (2 fish)", 10, 380);
            displayMainMessage("3. Freeze opponent's upgrade ability (3 fish)", 10, 395);

        }

        private void SpyMessage()
        {
            //TODO: display results given from spy
        }

        private void MissionMessage()
        {
            displayMainMessage("What mission would you like to send your troopers on?", 10, 350);
            displayMainMessage("1. Fish in frozen lakes", 10, 365);
            displayMainMessage("2. Raid neighboring glaciers", 10, 380);
            displayMainMessage("3. Steal opponents's fish", 10, 395);
        }

        private void NextTurn()
        {
            displayMainMessage("This concludes your turn. Press Enter to continue.", 10, 350);
        }

        private void ConfirmMessage()
        {
            displayMainMessage("Are you sure? (1 for yes/2 for no)", 10, 350);
        }

        private void displayPlayerTurn()
        {
            displayMainMessage("Player " + (playerNum+1) + "'s Turn", 200, 10);
        }

        private void displayCycleCount()
        {
            displayMainMessage("Cycle ", 500, 10);
        }

        private void displayResourceCount()
        {
            displayMainMessage("Fish = " , 10, 200);
            //displayMainMessage("Spies = " + players[playerNum].snowmenSpies, 10, 215);
            //displayMainMessage("Workers = ", 10, 230);

        }

        private void displayNextTurn()
        {
            displayMainMessage("It is now the next player's turn. Hit enter when they are ready.", 10, 350);
        }

    }
}