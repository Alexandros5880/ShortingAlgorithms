using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BucketSort
    {
        private void _min_max(ref int[] arr, ref int n, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            for (int i=1; i<n; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if ( arr[i] < min)
                {
                    min = arr[i];
                }
            }
        }

        public void Sort(int[] arr, int n)
        {
            // 1). Find Min and Max Values
            int minValue, maxValue;
            this._min_max(ref arr, ref n, out minValue, out maxValue);
            // 2). Get The value increase of every bucket (max_value / array_length)
            int valueIncreas = maxValue / n;
            // 3). Grab the values (start/stop value of every bucket)
            List<int> values = new List<int>();
            int value = minValue;
            for (int i = 0; i < (n * 2); i++) 
            {
                if (i > 0)
                {
                    if (i % 2 == 0)
                    {
                        value++;
                    }
                    else
                    {
                        value += valueIncreas;
                    }
                    values.Add(value);
                }
                else
                {
                    values.Add(minValue);
                }
            }
            // 4). Create n empty buckets wigth lwngth of the list
            List<List<int>> bucket = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                bucket.Add(new List<int>());
            }
            // 5). Put array elements in the right buckets
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n * 2; j++)
                {
                    if (j % 2 != 0)
                    {
                        if (arr[i] >= values[j - 1] && arr[i] <= values[j])
                        {
                            bucket[j/2].Add(arr[i]);
                        }
                    }
                }
            }
            // 6). Sort individual buckets
            for (int i = 0; i < n; i++)
            {
                bucket[i].Sort();
            }
            // 7). Concatenate all buckets into arr[]
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < bucket[i].Count; j++)
                {
                    arr[index++] = bucket[i][j];
                }
            }
        }
    }
}
