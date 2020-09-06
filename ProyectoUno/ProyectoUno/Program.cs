using System;
using System.Linq;

namespace ejerciciosCAI
{//guia 0 ejercicio 4
    class Program
    {
        static void Main(string[] args)
        {

            string text;
            string textb;

            text = Console.ReadLine();
            textb = Console.ReadLine();
            areAnagrams(text, textb);

            void areAnagrams(String first, String second)
            {

                char[] one = first.ToCharArray();
                Array.Sort(one);
                char[] two = second.ToCharArray();
                Array.Sort(two);

                Console.WriteLine(one.SequenceEqual(two));

            }
        }
    }
}
