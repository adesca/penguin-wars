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
        static int previousMessageState;
        static int buildingNum;
        static int missionNum;
        static int sabotageNum;
		
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

            if (current.IsKeyDown(Keys.Enter))
            {
                if (previous.IsKeyUp(Keys.Enter))
                {
                    returnInput = "Enter";
                }
            }
            previous = current;
            return returnInput;
        }

        public static int startMessageCycle(string key)
        {
            if (string.Compare(key, 0, "1", 0, 1, true) == 0)
            {
                return 1;
            }

            else if (string.Compare(key, 0, "2", 0, 1, true) == 0)
            {
                return 2;
            }

            else if (string.Compare(key, 0, "3", 0, 1, true) == 0)
            {
                return 3;
            }

            else if (string.Compare(key, 0, "4", 0, 1, true) == 0)
            {
                return 4;
            }

            else
            {
                return 0;
            }
        }

        public static int buildMessageCycle(int currentCycle, string key)
        {

            if (currentCycle == 1)
            {

                if (string.Compare(key, 0, "1", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 0;
                    return 11;
                }

                else if (string.Compare(key, 0, "2", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 1;
                    return 11;
                }

                else if (string.Compare(key, 0, "3", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 2;
                    return 11;
                }

                else if (string.Compare(key, 0, "4", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 3;
                    return 11;
                }

                else if (string.Compare(key, 0, "5", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 4;
                    return 11;
                }

                else if (string.Compare(key, 0, "6", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 5;
                    return 11;
                }

                else if (string.Compare(key, 0, "7", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 6;
                    return 11;
                }

                else if (string.Compare(key, 0, "8", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 7;
                    return 11;
                }

                else if (string.Compare(key, 0, "9", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 8;
                    return 11;
                }

                else if (string.Compare(key, 0, "0", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 9;
                    return 11;
                }

                else if (string.Compare(key, 0, "-", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    buildingNum = 10;
                    return 11;
                }

                else if (string.Compare(key, 0, "Back", 0, 1, true) == 0)
                {
                    return 0;
                }

                else
                {
                    return 1;
                }
            }

            else if (currentCycle == 11)
            {
                if (string.Compare(key, 0, "1", 0, 1, true) == 0)
                {
                    return -1;
                }

                else if (string.Compare(key, 0, "2", 0, 1, true) == 0)
                {
                    previousMessageState = 0;
                    return 1;
                }

                else
                {
                    return 11;
                }
            }

            else
            {
                return 1;
            }

        }

        public static int sabotageMessageCycle(int currentCycle, string key)
        {
            if (currentCycle == 2)
            {

                if (string.Compare(key, 0, "1", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    sabotageNum = 0;
                    return 21;
                }

                else if (string.Compare(key, 0, "2", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    sabotageNum = 1;
                    return 21;
                }

                else if (string.Compare(key, 0, "3", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    sabotageNum = 2;
                    return 21;
                }

                else if (string.Compare(key, 0, "Back", 0, 1, true) == 0)
                {
                    return 0;
                }

                else
                {
                    return 2;
                }
            }

            else if (currentCycle == 21)
            {
                if (string.Compare(key, 0, "1", 0, 1, true) == 0)
                {
                    return -2;
                }

                else if (string.Compare(key, 0, "2", 0, 1, true) == 0)
                {
                    previousMessageState = 0;
                    return 2;
                }

                else
                {
                    return 21;
                }
            }

            else
            {
                return 2;
            }
        }

        public static int sendSpyMessageCycle(int currentCycle, string key)
        {
            if (string.Compare(key, 0, "1", 0, 1, true) == 0)
            {
                return -3;
            }

            else if (string.Compare(key, 0, "2", 0, 1, true) == 0)
            {
                return 0;
            }

            else
            {
                return 3;
            }
        }

        public static int missionMessageCycle(int currentCycle, string key)
        {
            if (currentCycle == 4)
            {

                if (string.Compare(key, 0, "1", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    missionNum = 0;
                    return 41;
                }

                else if (string.Compare(key, 0, "2", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    missionNum = 1;
                    return 41;
                }

                else if (string.Compare(key, 0, "3", 0, 1, true) == 0)
                {
                    previousMessageState = currentCycle;
                    missionNum = 2;
                    return 41;
                }

                else if (string.Compare(key, 0, "Back", 0, 1, true) == 0)
                {
                    return 0;
                }

                else
                {
                    return 4;
                }
            }

            else if (currentCycle == 41)
            {
                if (string.Compare(key, 0, "1", 0, 1, true) == 0)
                {
                    return -4;
                }

                else if (string.Compare(key, 0, "2", 0, 1, true) == 0)
                {
                    previousMessageState = 0;
                    return 4;
                }

                else
                {
                    return 41;
                }
            }

            else
            {
                return 4;
            }
        }
    }
}