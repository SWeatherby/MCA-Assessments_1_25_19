using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PA3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader in_file = new StreamReader("C:\\temp\\SampleTxt.txt");

            Console.WriteLine("**********");
            while (!in_file.EndOfStream)
            {
                string data = in_file.ReadLine();
                string[] newdata = data.Split(' ',',','.','!','?');


                for (int i = 0; i < newdata.Length; i++)
                {
                   string word = newdata[i];
                    string padWord = word.PadRight(8);

                    Console.WriteLine("*"+(padWord)+"*");
                    
                    
                }
                Console.Write("**********");
            }
            Console.ReadKey();
        }
        
    }
    
}
