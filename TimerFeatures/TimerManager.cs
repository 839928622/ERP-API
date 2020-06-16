using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP_API.TimerFeatures
{
    public class TimerManager
    {
        private Timer _timer;
        private AutoResetEvent _autoResetEvent;
        private Action _action;

        public DateTime TimerStarted { get; set; }

        public TimerManager(Action action)
        {
            _action = action;
            _autoResetEvent = new AutoResetEvent(false);
            _timer = new Timer(Excute, _autoResetEvent,1000,2000);
            TimerStarted = DateTime.Now;
        }

        public void Excute(object stateInfo)
        {
            _action();
            if ((DateTime.Now - TimerStarted).Seconds > 60)
            {
                _timer.DisposeAsync();
            }
        }
    }
}
