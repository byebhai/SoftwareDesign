using System;
using System.Collections.Generic;
using System.Text;

namespace Timer
{
    class iSubject
    {
        void Attach(iObserver observer);
        void Detach(iObserver observer);
        void Notify();
    }
}
