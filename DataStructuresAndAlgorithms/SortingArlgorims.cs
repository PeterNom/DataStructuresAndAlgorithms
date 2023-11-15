using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    internal class SortingArlgorims
    {
        private int[] my_array;
        
        public SortingArlgorims(int[] arrayToBeSorted) 
        {
            my_array = arrayToBeSorted;
        }
        //My implementation
        public int[] InsertionSort_1()
        {
            for(int x = 1; x < my_array.Length; x++)
            {
                int y = x;
                while (y>0 && (my_array[y] < my_array[y-1]))
                {
                    int temp = my_array[y - 1];
                    my_array[y-1] = my_array[y];
                    my_array[y] = temp;
                    y--;
                }
            }
            return my_array;
        }

        //Book implementation
        public int[] InsertionSort_2()
        {
            for (int x = 1; x < my_array.Length; x++)
            {
                int key = my_array[x];
                int y = x - 1;

                while (y >= 0 && my_array[y]>key)
                {
                    my_array[y+1] = my_array[y];
                    y--;
                }

                my_array[y + 1] = key;
            }
            return my_array;
        }

        public int[] Mergesort()
        {
            return my_array;
        }
        public int[] BubbleSort()
        {
            return my_array;
        }

        public int[] Heapsort()
        {
            return my_array;
        }

        public int[] Quicksort()
        {
            return my_array;
        }

        public int[] Heapsort()
        {
            return my_array;
        }
    }
}
