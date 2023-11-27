using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    internal class MinMaxAlgorithms
    {
        private int[] my_array;

        public MinMaxAlgorithms(int[] arrayToBeSorted)
        {
            my_array = arrayToBeSorted;
        }

        public int[] GetArray() { return my_array; }

        public int FindMaximumSubarray(int low, int high)
        {
            if (low > high)
                return int.MinValue;

            if (low == high)
                return my_array[low];

            int mid = (high + low) / 2;

            return Math.Max(Math.Max(FindMaximumSubarray(low, mid - 1), FindMaximumSubarray(mid + 1, high)), FindMaxCrossingSubarray(low, mid, high));

        }

        private int FindMaxCrossingSubarray(int low, int mid, int high)
        {
            // Include elements on left of mid. 
            int sum = 0;
            int left_sum = int.MinValue;
            for (int i = mid; i >= low; i--)
            {
                sum = sum + my_array[i];
                if (sum > left_sum)
                    left_sum = sum;
            }

            // Include elements on right of mid 
            sum = 0;
            int right_sum = int.MinValue;

            for (int i = mid; i <= high; i++)
            {
                sum = sum + my_array[i];
                if (sum > right_sum)
                    right_sum = sum;
            }

            return Math.Max(left_sum + right_sum - my_array[mid], Math.Max(left_sum, right_sum));
        }
    }
}
