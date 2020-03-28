//
// ICT2106 Software Design - Timer exercise
//
// A class that prints a message to the screen every time it receives a notification.
//

using System;

namespace Timer
{
    class TextAlarm: iObserver
    {
        // the message to be printed
        private string message;

        // time count value
        private int timeCount { set; get; }

        // constructor
        public TextAlarm(string messageIn, int timeCountIn)
        {
            // save the message for later
            message = messageIn;

            // save the time count for later
            timeCount = timeCountIn;
        }
		
		// to be invoked when the alarm is triggered
		public void Update()
		{
			Console.WriteLine(message);
		}

        // get the value of time count
        public int getTimeCount()
        {
            return timeCount;
        }

        // decrement the value of time count
        public void decrementTimeCount()
        {
            timeCount--;
        }
    }
}
