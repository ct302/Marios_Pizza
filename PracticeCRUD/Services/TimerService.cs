using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace PracticeCRUD.Services
{
    public class TimerService
    {

        public System.Timers.Timer myTimer { get; set; }

        int currentSignalTime;

        void handleTimer(object sender, ElapsedEventArgs e)
        {
            currentSignalTime = e.SignalTime.Second;
            

        }

        public TimerService(Timer  _myTimer)
        {
            currentSignalTime = 0;
            myTimer = _myTimer;
            myTimer = new Timer() { Enabled = true, Interval = 1000, AutoReset = true };
            myTimer.Elapsed += handleTimer;
            myTimer.Start();


        }

    }
}
