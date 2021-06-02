using System;
using System.Linq;

namespace assign1_programming_intro
{
    class q4
    {
        static void Main(string[] args)
        {
            int array_size;
            Console.WriteLine("How many integers you want to input?");
            array_size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[array_size];
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine("Enter element {0}", i);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            q4 PivotIndex = new q4();
            try
            {
                Console.WriteLine(PivotIndex.PivotIndex(nums));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int PivotIndex(int[] nums)
        {
            int total_sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total_sum += nums[i];
            }
            int sum = 0;
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                if (2 * sum + nums[i] == total_sum)
                {
                    return i;
                }
                sum += nums[i];

            }
            return -1;

        }
    }
}
