using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin_Wars
{
    class player
    {
        public Base playerBase;
        int[] enemyBaseIntel;
        int fish;

        public player() {
            playerBase = new Base();
            enemyBaseIntel = new int[10];
        }

        public string sabotage() { return null; }
        public string gatherIntel() { return null; }
        public string trooperMission() { return null; }
    }
}
