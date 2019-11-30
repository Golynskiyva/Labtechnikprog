using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyElevator.Presenter
{
    class Lift
    {
        private bool status = false;
        private bool orientation= true;
        private int numLevel=2;
        private int location=1;
        private bool[] indicStat;
        private int massL = 0;
        private int maxMass = 400;
        private bool overl =false;
        private int lastMass = 0;
        Model.Level l;
        Model.People p;
        Model.Statistics sta;
        public Lift(int n, Model.Level le, Model.People pe, Model.Statistics s)
        {
            l = le; p = pe; sta = s;
            numLevel = n;
            for (int i = 0; i < numLevel; i++) indicStat[i] = false;
            TimerCallback tm = new TimerCallback(Move);
            Timer timer = new Timer(tm, null,1000, 1000);
        }
        public void GetStatusIndic()
        {

        }
        public void Move(object ob)
        {
            if (!l.CheckBut(location)) l.Discon(location);
            lastMass = massL;
            for (int m = 0; m < p.GetNumbMan(); m++) if (p.Peopl[m].GetStatus() == 1 && p.Peopl[m].GetEndPos() == location)
                {
                    p.Peopl[m].Unload();
                    massL-= p.Peopl[m].GetMass();
                }

                    for (int m = 0; m< p.GetNumbMan(); m++) if(p.Peopl[m].GetStatus()==0 && p.Peopl[m].GetStartPos() == location)
                {
                    if (Overload(p.Peopl[m].GetMass())) p.Peopl[m].Loading() ;
                }
            if (orientation)
            {
                int next = location;
                for(int i = location; i<=numLevel;i++)
                {
                    if (l.CheckBut(i)) next++;
                }
                if (next == location) 
                {
                    bool chek = false;
                    for (int j = location; j > 0; j--) if (l.CheckBut(j)) chek = true;
                    if (chek)
                    {
                        if (massL != 0) chek = false;
                        sta.EditNumTrip(chek);
                    }
                                orientation = false; 
                }
                else location++;
            }
            else
            {
                int next = location;
                for (int i = location; i>0 ; i--)
                {
                    if (l.CheckBut(i)) next--;
                }
                if (next == location)
                {
                    bool chek = false;
                    for (int j = location; j <= numLevel; j++) if (l.CheckBut(j)) chek = true;
                    if (chek)
                    {
                        if (massL != 0) chek = false;
                        sta.EditNumTrip(chek);
                    }
                    orientation = false;
                }
                else location--;
            }
        }
        public bool Overload (int masH)
        {
            bool res = true;
            if (massL + masH <= maxMass) res = false;
            return res;
        }
    }
}
