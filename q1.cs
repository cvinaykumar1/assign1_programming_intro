using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace assign1_programming_intro
{
    class q1
    {
        static void Main(string[] args)
        {
            string moves;

            Console.WriteLine("Input sequence of moves:");
            moves = Console.ReadLine();
            q1 JudgeCircle = new q1();
            q1 IsValid = new q1();

            while (!q1.IsValid(moves))
            {
                Console.WriteLine("Moves can be only U R L D. Please Re-Input sequence of moves:");
                moves = Console.ReadLine();

            }
            Console.WriteLine(JudgeCircle.JudgeCircle(moves));
        }

        public static bool IsValid(string str)
        {
            Regex regex = new Regex("^[URLD]+$");
            return regex.IsMatch(str);
        }

        public bool JudgeCircle(string moves)
        {
            var directions = new Dictionary<char, int>()
            {
                { 'U', 0 },
                { 'R', 0 },
                { 'D', 0 },
                { 'L', 0 },
            };

            foreach (char c in moves)
            {
                if (c.Equals('U'))
                {
                    directions['U'] += 1;
                }
                else if (c.Equals('R'))
                {
                    directions['R'] += 1;
                }
                else if (c.Equals('D'))
                {
                    directions['D'] += 1;
                }
                else if (c.Equals('L'))
                {
                    directions['L'] += 1;
                }
            }

            bool origin = false;
            if (directions['U'] == directions['D'] && directions['L'] == directions['R'])
            {
                origin = true;
            }
            return origin;
        }
    }
}
