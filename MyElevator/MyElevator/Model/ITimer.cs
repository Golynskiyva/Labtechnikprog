﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElevator.Model
{
    public  interface ITimer
    {

        event EventHandler Tick;

        bool Enabled { get; set; }
        int Interval { get; set; }

        void Start();
        void Stop();
    }
}
