//
// ICT2106 Software Design - Timer exercise
//
// Main program.
//

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a clock
            Timer timer = new Timer();

            // create some alarms
            iObserver alarm = new TextAlarm(10, "Wake up!");

            // attach the alarms to the clock
            timer.Attach(alarm);

            // run the clock for thirty seconds
            timer.Run(3);
        }
    }
}
