using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short
{
    public class BubbleSort
    {
        private void _swap(ref int xp, ref int yp)
        {
            int temp = xp;
            xp = yp;
            yp = temp;
        }

        public void Sort(int[] arr, int n)
        {
            int i, j;
            for (i=0; i<n-1; i++)
            {
                for(j=0; j<n-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        this._swap(ref arr[j], ref arr[j+1]);
                    }
                }
            }
        }
    }

}
