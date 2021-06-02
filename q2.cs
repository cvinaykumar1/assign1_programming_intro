using System;

namespace assign1_programming_intro
{
    class q2
    {
        static void Main(string[] args)
        {
            string sentence;

            Console.WriteLine("Input a sentence");
            sentence = Console.ReadLine();
            q2 CheckIfPangram = new q2();
            Console.WriteLine(CheckIfPangram.CheckIfPangram(sentence));
        }

        public bool CheckIfPangram(string str)
        {
            bool[] array = new bool[26]; // used to store occurrence of each alphabet
            //quickCheck
            if (str.Length < 26)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 'a' && str[i] <= 'z')
                    {
                       array[str[i] - 'a'] = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                for(int i=0; i<=25; i++)
                {
                    if(array[i] == false)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
