using MyElevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyElevator.Presenter
{
    public class SystemLift
    {
        private bool sysStatus = false;
        private int NumLevel;
        private Form1 f1;
        
        private int stman;
        public People peopl;
        private MLift lft;
        private Lift fl1;
        private Statistics statist;
        private Level lev;
        public SystemLift(Form1 f)
        {
            f1 = f;
            fl1 = f.fLift;

        }
        public void StartSys(string s1, string s2)
        {
            NumLevel = Convert.ToInt32(s1);
            stman = Convert.ToInt32(s2);
            //string messege = "Количество людей " + stman;
            //f1.GetBarStatusMan(messege);
            sysStatus = true;
            lev = new Level(NumLevel);
            if (stman == 0) {peopl = new People(lev); }
            else {peopl = new People(stman, NumLevel, lev); }
            statist = new Statistics(peopl);
            lft = new Presenter.MLift(NumLevel, lev, peopl, statist);
            RefreshInfo();
            //TimerCallback tm = new TimerCallback(RefreshInfo);
            //Timer timer = new Timer(tm, null, 1000, 1000);
        }
        public bool StopSys()
        {
            bool res = false;
            if (sysStatus == true && lft.massL == 0)
            {
                sysStatus = false;

                f1.fStat.activForm();
            }
            return res;
        }
        public void AddMan(string startlev, string endlev)           
        {
            peopl.Add(Convert.ToInt32(startlev), Convert.ToInt32(endlev));
        }
        public int GetStatistic(int numlab)
        {
            int result = 0;
            if (numlab == 1) result = statist.numTripAll;
            if (numlab == 2) result = statist.numTripIdle ;
            if (numlab == 3) result = statist.massAll;
            if (numlab == 4) result = statist.humEnd;
            return result;
        }
        public void RefreshInfo()
        {
            f1.UpdateInfo(peopl.GetAllStat());
            string massage = "Количество людей всего: " + peopl.GetNumbMan() +"; в лифте: " + peopl.GetHumLift();
            f1.GetBarStatusMan(massage);
            fl1.updateInfo("Привет");
            f1.fLift.updateInfo(lft.GetStatusIndic());
        }
        //lev.getInfoLevel()
        /*public void SetLevel(string s)
        {
            NumLevel = Convert.ToInt32(s);
        }
        public void SetStartMan(string s)
        {
            stman = Convert.ToInt32(s);
        }*/
    }
}
