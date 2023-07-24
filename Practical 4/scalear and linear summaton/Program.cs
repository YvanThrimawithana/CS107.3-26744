using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scalear_and_linear_summaton
{
    internal class Program
    {

        //create a 10 digit array and find the linear and the scalar sum. 
        static void Main(string[] args)
        {
            int[] num= new int[10];
            int sum=0;

            //for loop 
            for (int i=0; i<10; i++) 
            {
                Console.WriteLine("Enter value : ");
                num[i]= int.Parse(Console.ReadLine());
                
            }

            for (int i=0;i<10; i++) 
            {
                sum = +num[i];
                Console.Write(sum);
            }

            
            
        }
    }
}
