using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin_Wars
{
    class Base
    {
        private int wealth;
        private building[] buildings = new building[10];
        private snowball superSnowball;

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

    }
}
