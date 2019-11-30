using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElevator.Model
{
    class Level
    {
        private int numLevel = 0;
        private bool[] indicStat;
        public Level(int n) 
        { 
            numLevel = n;
            indicStat = new bool[numLevel];
            for (int i = 0; i < numLevel; i++) indicStat[i] = false;

        }
        public void Press(int l) 
        {
            indicStat[l - 1] = true;
        }
        public void Discon(int loc)
        {
            indicStat[loc - 1] = false;
        } 
        public bool CheckBut(int l)
        {
            if (indicStat[l - 1]) return false;
            else return true;
        }

    }
}
