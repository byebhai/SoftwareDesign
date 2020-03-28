//
// ICT2106 Software Design - Timer exercise
//
// A class representing a timer.
//
namespace Timer
{
    class Timer: iSubject
    {
        // repeatedly wait one second, exiting after numberOfTicks iterations
        public void Run(int numberOfTicks)
        {
            while (numberOfTicks > 0)
            {             
                System.Threading.Thread.Sleep(1000);
                System.Console.WriteLine("Sleeping...");
                Notify();
                numberOfTicks--;
            }
            System.Console.ReadLine();
        }

        // declare list of observers and list of observers that should be removed (detached)
        private List<iObserver> listObserver;
        private List<iObserver> listRemove;

        //constructor
        public Timer()
        {
            listObserver = new List<iObserver>();
            listRemove = new List<iObserver>();
        }

        // notify observers about changes
        // add observers that must be detached to listRemove
        private void Notify()
        {
            foreach (var i in listObserver)
            {
                if (i.getTimeCount() == 0)
                {
                    i.update();
                    listRemove.Add(i);
                }
                else
                {
                    i.decrementTimeCount();
                }
            }

            // check the list of observers to be detached
            checkListRemove();
        }

        // attach observer to the subject
        public void Attach(iObserver observer)
        {
            listObserver.Add(observer);
        }

        // detach observer from the subject
        public void Detach(iObserver observer)
        {
            listObserver.Remove(observer);
        }

        // check listRemove for list of observers to be detached
        private void checkListRemove()
        {
            foreach (var i in listRemove)
            {
                Detach(i);
            }

            // clear the list of observers that are to be detached
            listRemove.Clear();
        }

    }
}
