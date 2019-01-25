using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2
{
    class Program
    {
        static void Main(string[] args)
        {
           bool check = false;
            
           Console.WriteLine("Enter a word");
           check = PalindromeChecker(Console.ReadLine());
            
            if (check == true)
            {
                Console.WriteLine("Your word is a palindrome");
            }

            else
            {
                Console.WriteLine("Your word is not a palindrome");
            }
            Console.ReadKey();
            
        }
        static bool PalindromeChecker(string word)
        {

            string reverse = "";
           
           
            for (int j = word.Length - 1; j >= 0; j--)
            {
                reverse += word[j];
            }
           
            if (word == reverse)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }  

    }
}
