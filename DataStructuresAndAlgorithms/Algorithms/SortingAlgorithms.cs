using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataStructuresAndAlgorithms.Algorithms
{
    internal class SortingAlgorithms
    {
        private int[] my_array;

        public SortingAlgorithms(int[] arrayToBeSorted)
        {
            my_array = arrayToBeSorted;
        }

        public int[] GetArray() { return my_array; }

        //My implementation
        public int[] InsertionSortV1()
        {
            for (int x = 1; x < my_array.Length; x++)
            {
                int y = x;
                while (y > 0 && my_array[y] < my_array[y - 1])
                {
                    int temp = my_array[y - 1];
                    my_array[y - 1] = my_array[y];
                    my_array[y] = temp;
                    y--;
                }
            }
            return my_array;
        }

        //Book implementation
        public int[] InsertionSortV2()
        {
            for (int x = 1; x < my_array.Length; x++)
            {
                int key = my_array[x];
                int y = x - 1;

                while (y >= 0 && my_array[y] > key)
                {
                    my_array[y + 1] = my_array[y];
                    y--;
                }

                my_array[y + 1] = key;
            }
            return my_array;
        }

        public int[] BubbleSort()
        {
            bool finishFlag = false;

            for (int i = 1; i < my_array.Length; i++)
            {
                finishFlag = true;

                for (int x = 1; x < my_array.Length; x++)
                {
                    if (my_array[x] < my_array[x - 1])
                    {
                        int temp = my_array[x];
                        my_array[x] = my_array[x - 1];
                        my_array[x - 1] = temp;
                        finishFlag = false;
                    }
                }
                if (finishFlag) return my_array;
            }
            return my_array;
        }

        public void Mergesort(int start, int end)
        {
            if (start >= end)
                return;

            int mid = (end - start) / 2 + start;

            Mergesort(start, mid);
            Mergesort(mid + 1, end);

            Merge(start, mid, end);
        }
        private void Merge(int start, int mid, int end)
        {
            int[] left = new int[mid - start + 1];
            int[] right = new int[end - mid];


            for (int i = 0; i < left.Length; i++)
                left[i] = my_array[start + i];
            for (int i = 0; i < right.Length; i++)
                right[i] = my_array[mid + 1 + i];

            int indexOfLeft = 0;
            int indexOfRight = 0;
            int indexOfMergedArray = start;

            while (indexOfLeft < left.Length && indexOfRight < right.Length)
            {
                if (left[indexOfLeft] <= right[indexOfRight])
                {
                    my_array[indexOfMergedArray] = left[indexOfLeft];
                    indexOfLeft++;
                }
                else
                {
                    my_array[indexOfMergedArray] = right[indexOfRight];
                    indexOfRight++;
                }

                indexOfMergedArray++;
            }

            while (indexOfLeft < left.Length)
            {
                my_array[indexOfMergedArray]
                    = left[indexOfLeft];
                indexOfLeft++;
                indexOfMergedArray++;
            }

            while (indexOfRight < right.Length)
            {
                my_array[indexOfMergedArray] = right[indexOfRight];
                indexOfRight++;
                indexOfMergedArray++;
            }
        }

        public int[] Heapsort()
        {
            return my_array;
        }

        public int[] Quicksort()
        {
            return my_array;
        }
    }
}
