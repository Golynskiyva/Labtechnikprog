using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElevator.Model
{
    class Statistics
    {
        private DateTime timeStart;
        private DateTime timeStop;
        private int numTripAll = 0;
        private int numTripIdle = 0;
        private int massAll = 0;
        private int humEnd = 0;
        People p;
        public Statistics(People pe) 
        {
            p = pe;
        }
        public void Start() 
        {
            timeStart = DateTime.Now;

        }
        public void Stop()
        {
            timeStop = DateTime.Now;
            massAll = p.GetMassAll();
            humEnd = p.GetHumEnd();
            
        }
        public void EditNumTrip(bool idle)
        {
            numTripAll++;
            if (idle) numTripIdle++;
        }
        
        
    }
}
