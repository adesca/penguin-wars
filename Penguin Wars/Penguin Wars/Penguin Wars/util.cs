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
    public class util
    {
		static KeyboardState previous;
        
		
        public static string keyPush() //determines if a key was pushedd
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

    }
}