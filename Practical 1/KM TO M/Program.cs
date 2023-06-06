using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM_TO_M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add Distance (KM) : ");
            double km = double.Parse(Console.ReadLine());

            ConvertValues objConvertValues = new ConvertValues();
            objConvertValues.kilometertometer(km);

            Console.WriteLine("M value us : " + double m);

            

        }
    }
}
