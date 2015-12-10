using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin_Wars
{
    class building
    {
        public int level = 0;
        public int maxLevel = 3;
        public string name;
        private bool effectEnabled = false;
        public string desc;
        public int turnsToCompletedUpgrade = 0;

        public building(string newName,string newDesc)
        {
            name = newName;
            desc = newDesc;
        }

        public building(string newName, string newDesc, int level)
        {
            name = newName;
            desc = newDesc;
            maxLevel = level;
        }

        public void incrementLevel()
        {
            level++;
        }

        public bool isEnabled() { return effectEnabled; }


    }
}
