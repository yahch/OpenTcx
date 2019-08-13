using System;

namespace OpenTcx.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var tcx = new OpenTcx.Tcx();
            var data = tcx.AnalyzeTcxFile(@"C:\Users\zhix\Desktop\2017-06-05-07-23-04.tcx");
            if (data == null) return;
            Console.WriteLine("Sports Activity Count:" + data.Activities.Activity.Length);
            if (data.Activities.Activity.Length < 1) return;
            var activity0 = data.Activities.Activity[0];
            Console.WriteLine("ID:" + activity0.Id);
            Console.WriteLine("Sport:" + activity0.Sport);
            Console.WriteLine("Sport:" + activity0.Sport);
            Console.WriteLine("Laps:" + data.Activities.Activity[0].Lap.Length);
            Console.WriteLine("GPS Tracks:" + data.Activities.Activity[0].Lap[0].Track.Length);
        }
    }
}
