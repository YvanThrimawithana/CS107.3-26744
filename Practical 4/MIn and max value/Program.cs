using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIn_and_max_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a c# program that can find the min and max value from a single dimensional array

            Console.WriteLine("Enter array size : "); 
            int arrsize=int.Parse(Console.ReadLine());

            int [] arr=new int[arrsize];

            for (int i = 0; i < arrsize; i++) 
            {
                Console.WriteLine("Enter value : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int big = arr[0];
            int small = arr[0];

            for(int i =0; i < arrsize; i++) 
            {
                if (arr[i] > big) 
                {
                    big= arr[i];
                }

                if (arr[i] < small) 
                {
                    small= arr[i];
                }

                

            }
            Console.WriteLine("Max value : " + big + "Min value : " + small);
        }
    }
}
