using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader in_file = new StreamReader("C:\\Users\\CCA014\\source\\repos\\SampleCode\\SampleCode\\Program.cs");

            bool checker = false;
            while (!in_file.EndOfStream)
            {
                string data = in_file.ReadLine();
                string[] newdata = data.Split(' ');


                for (int i = 0; i < newdata.Length; i++)
                {
                    while (checker == false)
                    {


                        string comment = newdata[i];

                        if (comment == "//")
                        {
                            checker = true;
                            Console.Write(newdata[i]);
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
