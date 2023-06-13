using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which operation do you choose ? \n 1. Addition \n 2. Subtraction \n 3. Multiply \n 4. Divison \n \n Insert value : ");
            int op = int.Parse(Console.ReadLine());

            Console.Write("\nEnter num 1 : "); 
            int num1= int.Parse(Console.ReadLine());

            Console.Write("Enter num 2 : "); 
            int num2= int.Parse(Console.ReadLine());    

            CalculateValues objcal = new CalculateValues();
            if (op == 1)
            {
                int add = objcal.add(num1, num2);
                Console.Write("\nYour value is : " + add);
            }
            else if (op == 2)
            {
                int sub = objcal.sub(num1, num2);
                Console.Write("\nYour value is : " + sub);


            }

            else if (op == 3)
            {
                int mul = objcal.mul(num1, num2);
                Console.Write("\nYour value is : " + mul);
            }

            else if (op == 4)
            {
                int div= objcal.div(num1, num2);
                Console.Write("\nYour value is : " + div);
                

            }
           
            else 
            {
                Console.Write("Invalid operation");
            }
            Console.WriteLine("\n");
        
        }
    }
}
