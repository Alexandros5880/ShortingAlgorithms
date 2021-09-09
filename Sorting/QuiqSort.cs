using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuiqSort
    {

        private void _swap(ref int xp, ref int yp)
        {
            int temp = xp;
            xp = yp;
            yp = temp;
        }

        private int _Partition(int[] nums, int low, int high)
        {
            int i = low - 1;
            int pivot = nums[high];
            for (int j = low; j < high; j++)
            {
                if(nums[j] <= pivot)
                {
                    i++;
                    this._swap(ref nums[i], ref nums[j]);
                }
            }
            this._swap(ref nums[i+1], ref nums[high]);
            return i + 1;
        }

        public void Sort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pivot = this._Partition(nums, low, high);
                this.Sort(nums, low, pivot - 1);
                this.Sort(nums, pivot + 1, high);
            }
        }

    }

}
