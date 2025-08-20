namespace InterviewProblems.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
    /*
      Functionality: 
        2 Arrays of integer of same size, reverse the second array (if needed) to match the sequence in the first array.
      Use cases:
        [1,2,3,4] and [1,4,3,2]
        [1,2,3,4] and [4,3,2,1]
        [1,2,3,4] and [1,3,2,4]
      Boundary cases
        [] and []
        [1] and [1]
        Large sized arrays
      Logic
        Check if First Array is Enumerable.SequenceEqual with Second Array. If yes, then return true.
        For each element in First Array
          Check if the element in the Second Array in the same index as First Array and if they match move to the next element
          Else
            Find the index of the current element of First Array in Second Array
            If the index is not found, then the arrays do not match.
            Else
              Swap the elements in the Second Array using the current index and index of the element from First Array in the Second Array.      
      Tests
    */

    class ReverseToMakeEqual
    {
        // static void Main(string[] args)
        // {
        //     // Call areTheyEqual() with test cases here
        //     arr_a = new int[4] { 1, 2, 3, 4 };
        //     arr_b = new int[4] { 4, 3, 2, 1 };

        //     if (!areTheyEqual(arr_a, arr_b))
        //     {
        //         makeArraysEqual(arr_a, arr_b);
        //     }

        //     printArray(arr_a);
        //     printArray(arr_b);
        // }

        private static int[] arr_a;
        private static int[] arr_b;

        private static bool areTheyEqual(int[] arr_a, int[] arr_b)
        {
            // Write your code here
            if (arr_a.Length != arr_b.Length)
            {
                return false;
            }

            return Enumerable.SequenceEqual(arr_a, arr_b);
        }

        private static void makeArraysEqual(int[] arr_a, int[] arr_b)
        {
            for (int i = 0; i < arr_a.Length; i++)
            {
                if (arr_a[i] != arr_b[i])
                {
                    int indexInArray = getIndexOfElementInArray(arr_a[i], arr_b);
                    if (indexInArray < 0)
                    {
                        return;
                    }
                    var temp = arr_b[i];
                    arr_b[i] = arr_b[indexInArray];
                    arr_b[indexInArray] = temp;
                }
            }
        }

        private static int getIndexOfElementInArray(int element, int[] arrToSearch)
        {
            for (int j = 0; j < arr_b.Length; j++)
            {
                if (arrToSearch[j] == element)
                {
                    return j;
                }
            }

            return -1;
        }

        private static void printArray(int[] arrayToPrint)
        {
            for (int k = 0; k < arrayToPrint.Length; k++)
            {
                Console.WriteLine(arrayToPrint[k]);
            }
        }
    }
}