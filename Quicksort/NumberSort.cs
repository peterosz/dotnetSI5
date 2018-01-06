using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    public class NumberSort
    {
        public int[] numsToSort = new int[10];

        public NumberSort()
        {
            Random random = new Random();
            for (int i = 0; i < numsToSort.Length; i++)
            {
                numsToSort[i] = random.Next(50);
            }
        }

        public void SortIt(int[] array)
        {
            SortIt(array, 0, array.Length - 1);
        }

        void SortIt(int[] array, int left, int right)
        {
            if (left >= right) return;

            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);
            SortIt(array, left, index - 1);
            SortIt(array, index, right);
        }

        int Partition(int[] array, int left, int right, int pivot)
        {
            while(left<= right)
            {
                while(array[left] < pivot)
                {
                    left++;
                }

                while(array[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    SwapElements(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        void SwapElements(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
