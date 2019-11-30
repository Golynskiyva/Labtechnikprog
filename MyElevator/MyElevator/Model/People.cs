using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElevator.Model
{
    class People
    {
        public int NumbMan = 0;
        public List<Man> Peopl;
        Level le;

        public People(Level l)
        {
            le = l;
        }
        public People(int num, int nl, Level l) 
        {
            le = l;
            NumbMan += num;
            for(int i=0; i<num; i++) Peopl.Add(new Man(nl, le));
        }
        public void Add(int st, int en) 
        {
            Peopl.Add(new Man(st, en, le));
            NumbMan++;
        }
        public string GetAllStat() 
        {
            string st = "Нет Данных";
            for(int i = 0; i<NumbMan; i++)
            {
                if(Peopl[i].GetStatus() != 3) 
                {
                    string buf ="Пустой";
                    if (Peopl[i].GetStatus() == 0) buf = "Человек под номером " + (i+1).ToString() + " ожидает лифт на этаже " + (Peopl[i].GetStartPos()).ToString();
                    if (Peopl[i].GetStatus() == 1) buf = "Человек под номером " + (i + 1).ToString() + " находится в движущемся лифте ";
                    if (Peopl[i].GetStatus() == 2) buf = "Человек под номером " + (i + 1).ToString() + " доставлен на этаж " + (Peopl[i].GetEndPos()).ToString();
                    if (st == "Нет Данных") st = buf;
                    else st += buf;
                }
            }
            return st;
        }
        public int GetHumLift()
        {
            int res = 0;
            for (int i = 0; i < NumbMan; i++) if (Peopl[i].GetStatus() == 1) res++;
            return res;
        }
        public int GetMassAll()
        {
            int res = 0;
            for (int i = 0; i < NumbMan; i++) if (Peopl[i].GetStatus() == 3) res+=Peopl[i].GetMass();
            return res;
        }
        public int GetHumEnd()
        {
            int res = 0;
            for (int i = 0; i < NumbMan; i++) if (Peopl[i].GetStatus() == 3) res++;
            return res;
        }
        public int GetNumbMan()
        {
            return NumbMan;
        }
    }
}
