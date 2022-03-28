using System;

namespace _28._03_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Salam     Dunya";
            Console.WriteLine(whiteSpaceX(word));
        }
        static string whiteSpaceX(string sentence)
        {
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    count++;
                    if (count > 1)
                    {
                        int firstIndex = sentence.IndexOf(' ');
                        int lastIndex = sentence.LastIndexOf(' ');
                        int difference = lastIndex - firstIndex;
                        sentence = sentence.Remove(firstIndex, difference);
                    }
                }
            }
            return sentence;
        }
    }
}
