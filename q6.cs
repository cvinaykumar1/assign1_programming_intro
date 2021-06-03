using System;
using System.Text;
using System.Linq;

namespace assign1_programming_intro
{
    class q6
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine("Input your sentence?");
            sentence = Console.ReadLine();

            q6 ToGoatLatin = new q6();
            try
            {
                Console.WriteLine(ToGoatLatin.ToGoatLatin(sentence));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string ToGoatLatin(string sentence)
        {
            string[] words = sentence.Split(' ');
            string vowels = "a A e E i I o O u U";  // vowels
            string final_sentence = "";             // final result
            string index_letter = "a";              // 'a' is added to each word based on index

            // iterate over each word in the sentence
            foreach (string w in words)
            {
                // place holder for final words in the sentence
                string word_in_final = "";
                if (vowels.Contains(w[0]))
                {
                    word_in_final = w + "ma"; // if the word starts with a vowel add 'ma'
                }
                else
                {
                    word_in_final = w.Substring(1) + w[0] + "ma"; // if the word doesn't start with a vowel add put first char at the last and add 'ma' at end
                }
                word_in_final += index_letter;
                index_letter += 'a'; // keep appending a's end of each word based on its index

                final_sentence += word_in_final + ' ';
            }
            return final_sentence;
        }
    }
}
