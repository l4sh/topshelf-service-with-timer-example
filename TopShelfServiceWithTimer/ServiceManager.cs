using System;
using System.Threading;


namespace TopShelfServiceWithTimer
{
    class ServiceManager
    {
        protected TimeSpan shutdownDelay;
        protected ManualResetEvent shutdownEvent;

        SystemTimer serviceTimer;

        public ServiceManager()
        {
            shutdownDelay = new TimeSpan(0, 0, 3);
            shutdownEvent = new ManualResetEvent(false);

            serviceTimer = new SystemTimer();
        }

        public void Start()
        {
            serviceTimer.Initialize();
        }

        public void Stop()
        {
            serviceTimer.Dispose();
            shutdownEvent.Dispose();
        }

    }
}
