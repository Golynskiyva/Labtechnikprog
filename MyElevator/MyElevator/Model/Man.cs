using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyElevator.Model
{
    class Man
    {
        private int status = 0;
        private int endPos;
        private int startPos;
        private int mass;
        private int reaction;
        Level l;

        public Man(int n, Level lev)
        {
            Random rnd = new Random();
            l = lev;
            endPos = rnd.Next(1, n);
            startPos = rnd.Next(1, n-1);
            if (endPos == startPos) startPos++;
            mass = rnd.Next(20, 120);
            reaction = rnd.Next(1, 5);
            TimerCallback tm = new TimerCallback(Call);
            Timer timer = new Timer(tm, null, reaction*1000, -1);

        }
        public Man(int s, int e, Level lev)
        {
            Random rnd = new Random();
            l = lev;
            endPos = e;
            startPos = s;
            if (endPos == startPos) startPos++;
            mass = rnd.Next(20, 120);
            reaction = rnd.Next(1, 5);
            TimerCallback tm = new TimerCallback(Call);
            Timer timer = new Timer(tm, null, reaction * 1000, -1);
        }
        public void Call(object obj) 
        {
            if(l.CheckBut(startPos)) l.Press(startPos);
        }
        public void Loading() 
        {
            status++;
            
        }
        public void Unload() 
        {
            status++;
            TimerCallback tm = new TimerCallback(EndLife);
            Timer timer = new Timer(tm, null, 5000, -1);
        }
        public void EndLife(object ob)
        {
            status++;
        }
        public int GetStatus() 
        {
            return status;
        }
        public int GetStartPos()
        {
            return startPos;
        }
        public int GetEndPos()
        {
            return endPos;
        }
        public int GetMass()
        {
            return mass;
        }
    }
}
