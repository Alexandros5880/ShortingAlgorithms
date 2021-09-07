using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short
{
    public class QuiqSort
    {



        private int _Partition(int[] nums, int low, int high)
        {
            int i = low - 1;
            int pivot = nums[high];
            for (int j = low; j < high; j++)
            {
                if(nums[j] <= pivot)
                {
                    i++;
                    int first = nums[i];
                    nums[i] = nums[j];
                    nums[j] = first;
                }
            }
            int last = nums[i + 1];
            nums[i + 1] = nums[high];
            nums[high] = last;
            return i + 1;
        }


        public void Short(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pivot = this._Partition(nums, low, high);
                this.Short(nums, low, pivot - 1);
                this.Short(nums, pivot + 1, high);
            }
        }

    }

}
