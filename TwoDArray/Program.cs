//
// ICT2106 Software Design - 2D array example
//
// Main program.
//
// Author: Nicholas Sheppard
//
using System;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and fill a 2 x 3 array of integers
            ITwoDArray<int> array = new TwoDArrayGeneric<int>(2, 3);
            array.Set(0, 0, 9); array.Set(0, 1, 4); array.Set(0, 2, 1);
            array.Set(1, 0, 2); array.Set(1, 1, 5); array.Set(1, 2, 3);

            // display the array row by row
            // reverse the direction at the end of each row
            ITwoDIterator<int> iter = array.CreateRowMajorIterator();
            while (!iter.IsDone())
            {
                Console.Write(iter.Current() + " ");
                iter.NextTurn();
            }
            Console.WriteLine();

            // create and fill a 3 x 2 array of strings with null values
            ITwoDArray<string> newArray = new TwoDArrayGeneric<string>(3, 2);
            newArray.Set(0, 0, "Sarah"); newArray.Set(0, 1, null);
            newArray.Set(1, 0, "Yixin"); newArray.Set(1, 1, null);
            newArray.Set(2, 0, null); newArray.Set(2, 1, "Faizal");

            // display the array in row major order 
            // skip any null references in the array
            ITwoDIterator<string> newIter = newArray.CreateRowMajorIterator();
            while (!newIter.IsDone())
            {
                Console.Write(newIter.Current() + " ");
                newIter.Next();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
