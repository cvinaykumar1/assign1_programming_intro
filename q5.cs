using System;

namespace assign1_programming_intro
{
    class q3
    {
        static void Main(string[] args)
        {
            string word_1, word_2;
            Console.WriteLine("Input word 1?");
            word_1 = Console.ReadLine();
            Console.WriteLine("Input word 2?");
            word_2 = Console.ReadLine();

            q3 MergeAlternately = new q3();
            try
            {
                Console.WriteLine(MergeAlternately.MergeAlternately(word_1, word_2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string MergeAlternately(string word_1, string word_2)
        {
            string final_word = "";

            for (int i = 0; i < word_1.Length || i < word_2.Length; i++)
            {
                if (i < word_1.Length)
                {
                    final_word += word_1[i];
                }
                if (i < word_2.Length)
                {
                    final_word += word_2[i];
                }
            }
            return final_word;

        }
    }
}
