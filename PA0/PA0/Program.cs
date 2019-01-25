using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 0,1,1,0,1,0,1,0,0,1 }; //sample array to be sorted

            Sort(data);//function call to sort array

            for (int index = 0; index < data.Length; index++)//for loop to output elements of array
            {
                Console.Write(data[index]);//prints to console
            }
            Console.ReadKey();

        }

        static void Sort(int[] x)//function that sorts array
        {
            for (int i = 0; i < x.Length; i++)//for loop that runs through each element of the accepted array
            {
                for (int index = 0; index < (x.Length - 1); index++)//nested for loop to compare values of the array
                {
                    if (x[index + 1] < x[index])
                    {
                        int temp = x[index];//creates a temporary container to hold a value
                        x[index] = x[index + 1];
                        x[index + 1] = temp;
                    }


                }
            }
        }
    }
}


