using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElevator.Model
{
    public class Timer : ITimer
    {
        public bool Enabled { get ; set ; }
        public int Interval { get ; set ; }

        public event EventHandler Tick;

        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}
