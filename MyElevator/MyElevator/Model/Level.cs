using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElevator.Model
{
    public class Level
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
            int i = l - 1;
            if (indicStat[i]) return false;
            else return true;
        }
        public string getInfoLevel()
        {
            string result = "Нету информации";
            
            for (int i = 0; i < numLevel; i++)
            {
                string buf;
                if (indicStat[i]) buf = "Кнопка вызова на этаже " + (i + 1) + " активна";
                else buf = "Кнопка вызова на этаже " + (i + 1) + " не активна";
                if (result == "Нету информации") result = buf;
                else result += buf;
            }
            return result;
        }

    }
}
