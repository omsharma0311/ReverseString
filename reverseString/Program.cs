using System;

namespace reverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string str = Console.ReadLine();

            Console.WriteLine("Original string");
            Console.WriteLine(str);

            Console.WriteLine("Reversed String");

            var count = 0;
            foreach (var num in str) // getting count using for-each
                count++;
            //var count = str.Length-1; getting count using built-in function

            for (int j =count-1;j>=0;j--)
            {
                Console.Write(str[j]);
            }
        }
    }
}
