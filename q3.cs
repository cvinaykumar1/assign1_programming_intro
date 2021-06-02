using System;

namespace assign1_programming_intro
{
    class q3
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

            q3 NumIdenticalPairs = new q3();
            try
            {
                Console.WriteLine(NumIdenticalPairs.NumIdenticalPairs(nums, array_size));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int NumIdenticalPairs(int[] nums, int array_size)
        {
            int count = 0;
            for (int i = 0; i < array_size - 1; i++)
            {
                for (int j = i + 1; j < array_size; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
