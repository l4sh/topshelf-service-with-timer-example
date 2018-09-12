using System;
using System.Timers;


namespace TopShelfServiceWithTimer
{
    class SystemTimer : IDisposable
    {
        protected Timer timer;

        public void Dispose()
        {
            timer.Dispose();
        }

        public void Initialize()
        {
            timer = new Timer(10000); // 10 seconds
            timer.Elapsed += ServiceTasks.Run;
            timer.Enabled = true;
        }

    }
}
