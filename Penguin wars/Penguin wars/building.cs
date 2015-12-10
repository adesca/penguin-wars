using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin_wars
{
    class building
    {
        public int level = 0;
        public int maxLevel = 3;
        public string name;
        protected bool effectEnabled = false;
        public string desc;
        public int turnsToCompleteUpgrade = 3;
        public int buildTime = 0;

        //fields used internally, not part of the game
        public bool levelledUp = false;

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

        public void buildUp()
        {
            if(buildTime > 0)
                buildTime++;
            
            if((buildTime >= (turnsToCompleteUpgrade+level)) || (turnsToCompleteUpgrade+level < 0)) //The second condition ensurse that a building will be completed next turn even if it should technically take negative time
            {
                level++;
                buildTime = 0;
                levelledUp = true;
            }

            
        }

        public bool isEnabled() { return effectEnabled; }

        public void upgrade()
        {
            if (level < maxLevel)
                buildTime = 1;
            if (!isEnabled())
                effectEnabled = true;

            //to-do: art references
        }


    }

    class iceForge : building
    {
        public iceForge(string name, string desc) : base(name, desc)
        { }

    }

    class snowball : building
    {
        public snowball(string name, string desc) : base(name, desc, 10)
        { }

    }
}
