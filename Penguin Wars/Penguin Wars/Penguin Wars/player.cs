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

        public int skirmishStrengh = 50;
        public float armySize = 1; //double that represents the percentage of full strength the player is
        public bool hospitalBuilt = false;

        public int snowmenSpies = 5;
        int maxSpies = 5;
        public int sabotageChance = 66;
        public int sabotageDefense = 0;

        public int fishGenerationRate = 25;

        public player() {
            playerBase = new Base();
            enemyBaseIntel = new int[10];
        }

        public void playTurn()
        {
            //start of turn stuff
            //To-do: Display result of sabotage, skirmish, missions
            
            //upgrade each building
            buildBuildings();
            fish += fishGenerationRate;

            //To-Do: get player input 

            //end of turn stuff
            //To-do: Calculate sabotage chance

        }

        public string sabotage() { return null; }
        public string gatherIntel() {


            return null;
        }
        public string trooperMission() { return null; }

        private void buildBuildings()
        {
            string result = playerBase.build();

            for (int i = 0; i < result.Length; i++)
            {
                switch (result[i])
                {
                    case 'z':
                        maxSpies++; //spyforce
                        break;
                    case 'a':
                        if (snowmenSpies < maxSpies)
                            snowmenSpies++; //Snowman workshop
                        break;
                    case 'b':
                        sabotageDefense += 15; // Safeguards
                        break;
                    case 'c':
                        sabotageChance += 15; //saboteuses
                        break;
                    case 'd':
                        skirmishStrengh += 15; //barracks
                        break;
                    case 'e':
                        skirmishStrengh += 10; //ice forge
                        break;
                    case 'f':
                        skirmishStrengh += 20; //Standing penguarmy
                        break;
                    case 'g':
                        hospitalBuilt = true; //Penguospital
                        break;
                    case 'h':
                        playerBase.decreaseSnowballBuildTime(); //research lab
                        break;
                    case 'i':
                        fishGenerationRate += 15; //bank
                        break;
                    default:
                        break;
                }
            }
        }

        public void reduceStrength(double value)
        {
            value *= 1 - (playerBase.getHospitalLevel()*.2);
            armySize -= (float) value;
        }
    }
}
