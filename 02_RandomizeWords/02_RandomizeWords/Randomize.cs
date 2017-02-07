using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RandomizeWords
{
    class Randomize
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd=new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int rndIndex = rnd.Next(0,words.Length);
                var currentWord = words[i];
                var tempWord = words[rndIndex];
                words[i] = tempWord;
                words[rndIndex] = currentWord;
            }

            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}
