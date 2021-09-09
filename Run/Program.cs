using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;


namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums_1 = { 3, 634, 65, 7, 667, 4, 8, 56, 45, 768, 4, 656, 3245, 7, 7, 76676, 87874, 436, 56, 788, 78, 43, 12, 32, 11, 1 };
            QuiqSortFunction(nums_1);

            int[] nums_2 = { 3, 634, 65, 7, 667, 4, 8, 56, 45, 768, 4, 656, 3245, 7, 7, 76676, 87874, 436, 56, 788, 78, 43, 12, 32, 11, 1 };
            BubbleSort(nums_2);

            int[] nums_3 = { 3, 634, 65, 7, 667, 4, 8, 56, 45, 768, 4, 656, 3245, 7, 7, 76676, 87874, 436, 56, 788, 78, 43, 12, 32, 11, 1 };
            BucketSort(nums_3);

            Console.ReadKey();
        }



        public static void QuiqSortFunction(int[] nums)
        {
            Console.WriteLine("QuickShort:");
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("");

            QuiqSort qs = new QuiqSort();
            qs.Sort(nums, 0, nums.Length - 1);

            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("");
        }

        public static void BubbleSort(int[] nums)
        {
            Console.WriteLine("BubbleSort:");
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("");

            int n = nums.Length;
            BubbleSort bs = new BubbleSort();
            bs.Sort(nums, n);

            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("");
        }

        public static void BucketSort(int[] nums)
        {
            Console.WriteLine("BucketSort:");
            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("");

            int n = nums.Length;
            BucketSort bs = new BucketSort();
            bs.Sort(nums, n);

            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("");
        }

    }
}
