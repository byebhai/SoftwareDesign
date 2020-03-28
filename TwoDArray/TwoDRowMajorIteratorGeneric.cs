//
// ICT2106 Software Design - 2D array example
//
// Concrete row-major iterator for two-dimensional arrays.
//
// Author: Nicholas Sheppard
//
namespace TwoDArray
{
    class TwoDRowMajorIteratorGeneric<T> : ITwoDIterator<T>
    {
        // the collection being iterated through
        TwoDArrayGeneric<T> collection;

        // counters
        private int i, j;

        // constructor
        public TwoDRowMajorIteratorGeneric(TwoDArrayGeneric<T> collectionIn)
        {
            collection = collectionIn;
            i = 0;
            j = 0;
        }

        // get the current element of the iteration
        public T Current()
        {
            return collection.Get(i, j);
        }

        // move to the next element of the iteration
        public void Next()
        {
            j++;
            if (j >= collection.Columns())
            {
                j = 0;
                i++;
            }
        }

        // test whether or not the iteration has finished
        public bool IsDone()
        {
            return i >= collection.Rows();
        }

        // move to the next element of the iteration
        // but reverse the direction of the array
        public void NextTurn()
        {
            if (i % 2 == 0)
            {
                if (j >= collection.Columns() - 1)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            else
            {
                if (j == 0)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
        }
    }
}
