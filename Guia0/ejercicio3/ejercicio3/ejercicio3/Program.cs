using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine("Ingresar palabra capicua");
            palabra=Console.ReadLine();          
            Console.WriteLine(IsPalindrome(palabra));
            bool IsPalindrome(string text)
            {
                if (text.Length <= 1)
                    return true;
                else
                {
                    if (text[0] != text[text.Length - 1])
                        return false;
                    else
                        return IsPalindrome(text.Substring(1, text.Length - 2));
                }
            }
        }
    }
}
