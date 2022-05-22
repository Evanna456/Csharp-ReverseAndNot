using System;

namespace Csharp_ReverseAndNot
{
    class Program
    {
        private static void Main(string[] args)
        {
            program();
        }
        public static void program()
        {
            try
            {
                Console.WriteLine("Enter a number to reverse and not reverse");
                int number = Int32.Parse(Console.ReadLine());
                string string_number = number.ToString();
                int length = string_number.Length;
                string final_number = "";
                for (int it = length - 1; it >= 0; it--)
                {
                    final_number += string_number[it];
                }
                final_number += string_number;
                Console.WriteLine(final_number);
                Console.ReadLine();
            }
            catch (Exception x)
            {
                Console.WriteLine("Wrong Input/s");
                program();
            }
        }
    }
}