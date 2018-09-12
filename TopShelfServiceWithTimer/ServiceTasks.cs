using System;
using System.IO;
using System.Timers;


namespace TopShelfServiceWithTimer
{
    class ServiceTasks
    {
        public static void WriteDateToFile()
        {
            DateTime date = DateTime.Now;
            File.AppendAllText(@"C:\TopShelfServiceOutput.txt", date.ToString() + Environment.NewLine);
        }

        public static void Run(object source, ElapsedEventArgs e)
        {
            WriteDateToFile();
        }
    }
}
