using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Topshelf;

namespace TopShelfServiceWithTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<ServiceManager>(s =>
                {
                    s.ConstructUsing(name => new ServiceManager());
                    s.WhenStarted(serviceTimer => serviceTimer.Start());
                    s.WhenStopped(serviceTimer => serviceTimer.Stop());
                });

                x.SetDescription("Example for running a Timer withing a simple TopShelf service");
                x.SetDisplayName("TopShelf Service with Timer");
                x.SetServiceName("TopShelfServiceWithTimer");

                x.RunAsLocalSystem();
                x.StartAutomatically();
            });
        }
    }
}
