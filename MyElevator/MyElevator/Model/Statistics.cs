using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElevator.Model
{
    public class Statistics
    {
        public DateTime timeStart;
        public DateTime timeStop;
        public int numTripAll = 0;
        public int numTripIdle = 0;
        public int massAll = 0;
        public int humEnd = 0;
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
