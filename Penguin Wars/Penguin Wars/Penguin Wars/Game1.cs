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
        KeyboardState previous;
        int messagecycle = 0;
        Texture2D building = null;

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

            // TODO: Add your update logic here

            if (string.Compare(keyPush(), 0, "1", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 1;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }

                else if (messagecycle == 2)
                {
                    messagecycle = 3;
                }

            }
            else if (string.Compare(keyPush(), 0, "2", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
                
            }
            else if (string.Compare(keyPush(), 0, "3", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "4", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "5", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "6", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "7", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "8", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "9", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "0", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "-", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
                }
            }
            else if (string.Compare(keyPush(), 0, "Back", 0, 1, true) == 0)
            {
                if (messagecycle == 0)
                {
                    messagecycle = 4;
                }

                else if (messagecycle == 1)
                {
                    messagecycle = 2;
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
            base.Draw(gameTime);
        }

        private string keyPush() //determines if a key was pushedd
        {
            KeyboardState current = Keyboard.GetState();
            string returnInput = " ";
            if (current.IsKeyDown(Keys.D1))
            {
                if (previous.IsKeyUp(Keys.D1))
                {
                    returnInput = "1";
                }
            }

            if (current.IsKeyDown(Keys.D2))
            {
                if (previous.IsKeyUp(Keys.D2))
                {
                    returnInput = "2";
                }
            }

            if (current.IsKeyDown(Keys.D3))
            {
                if (previous.IsKeyUp(Keys.D3))
                {
                    returnInput = "3";
                }
            }

            if (current.IsKeyDown(Keys.D4))
            {
                if (previous.IsKeyUp(Keys.D4))
                {
                    returnInput = "4";
                }
            }

            if (current.IsKeyDown(Keys.D5))
            {
                if (previous.IsKeyUp(Keys.D5))
                {
                    returnInput = "5";
                }
            }

            if (current.IsKeyDown(Keys.D6))
            {
                if (previous.IsKeyUp(Keys.D6))
                {
                    returnInput = "6";
                }
            }

            if (current.IsKeyDown(Keys.D7))
            {
                if (previous.IsKeyUp(Keys.D7))
                {
                    returnInput = "7";
                }
            }

            if (current.IsKeyDown(Keys.D8))
            {
                if (previous.IsKeyUp(Keys.D8))
                {
                    returnInput = "8";
                }
            }

            if (current.IsKeyDown(Keys.D9))
            {
                if (previous.IsKeyUp(Keys.D9))
                {
                    returnInput = "9";
                }
            }

            if (current.IsKeyDown(Keys.D0))
            {
                if (previous.IsKeyUp(Keys.D0))
                {
                    returnInput = "0";
                }
            }
            
            if (current.IsKeyDown(Keys.OemMinus))
            {
                if (previous.IsKeyUp(Keys.OemMinus))
                {
                    returnInput = "-";
                }
            }

            if (current.IsKeyDown(Keys.Back))
            {
                if (previous.IsKeyUp(Keys.Back))
                {
                    returnInput = "Back";
                }
            }
            previous = current;
            return returnInput;
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
            displayMainMessage("Player 's Turn", 200, 10);
        }

        private void displayCycleCount()
        {
            displayMainMessage("Cycle ", 500, 10);
        }

        private void displayResourceCount()
        {
            displayMainMessage("Fish = ", 10, 200);
            displayMainMessage("Spies = ", 10, 215);
            displayMainMessage("Workers = ", 10, 230);

        }

    }
}