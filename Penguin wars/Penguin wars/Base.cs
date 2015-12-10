using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin_wars
{
    class Base
    {
        private int wealth;
        public building[] buildings = new building[10];
        public snowball superSnowball;

        public Base()
        {
            initializeBuildings();
        }

        public int getWealth() { return wealth; }
        public void changeWealth(int delta) {wealth += delta; }

        public override string ToString()
        {
            string result = "";
            for(int i =0; i<buildings.Length; i++)
            {
                result += buildings[i].name + "\t" + buildings[i].level+"\n";
            }
            result += "Supersnowball \t" + superSnowball.level+"\n"; 

            return result;
        }


        private void initializeBuildings()
        {
            buildings[0] = new building("spyforce", "");
            buildings[1] = new building("Snowman workshop", "");
            buildings[2] = new building("Safeguards", "");
            buildings[3] = new building("Saboteuses", "");
            buildings[4] = new building("Barracks", "");
            buildings[5] = new building("Ice forge", "");
            buildings[6] = new building("Standing Penguarmy", "");
            buildings[7] = new building("Penguospital", "");
            buildings[8] = new building("Snowball research lab", "");
            buildings[9] = new building("Bank", "");
            superSnowball = new snowball("superSnowball", "");
        }


        public void upgrade(int buildingIndex)
        {
            buildings[buildingIndex].upgrade();
        }

        public string build()
        {
            string returnValue = ""; //This value says what building was upgraded for use by the player object
            for (int i = 0; i < buildings.Length; i++)
            {
                buildings[i].buildUp();
                if (buildings[i].levelledUp)
                    returnValue += triggerEffect(i);
            }

            superSnowball.buildUp();

            return returnValue; 
        }

        private string triggerEffect(int index)
        {
            try
            {
                switch (index)
                {
                    case 0:
                        return "z"; //spyforce
                    case 1:
                        return "a"; //Snowman workshop
                    case 2:
                        return "b"; // Safeguards
                    case 3:
                        return "c"; //saboteuses
                    case 4:
                        return "d"; //barracks
                    case 5:
                        decreaseBuildTimes(); //ice forge
                        return "e";
                    case 6:
                        return "f"; //Standing penguarmy
                    case 7:
                        return "g"; //Penguospital
                    case 8:
                        return "h"; //research lab
                    case 9:
                        return "i"; //bank
                    default:
                        return "";
                }

               
            }
            finally
            {
                buildings[index].levelledUp = false;
            }
           
        }

        private void decreaseBuildTimes()
        {
            for(int i=0; i<buildings.Length; i++)
            {
                buildings[i].turnsToCompleteUpgrade--;
            }
        }


        //building specific methods
        public void decreaseSnowballBuildTime()
        {
            superSnowball.turnsToCompleteUpgrade -= 2;
        }

        public int getHospitalLevel()
        {
            return buildings[7].level;
        }

    }
}
