using System;

namespace area_and_circumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());

            area_cirum objvalues = new area_cirum();
            objvalues.area(r);

            double area = objvalues.area(r);
            Console.WriteLine("AREA : " + area);

            double circum = objvalues.circum(r);
            Console.WriteLine("CIRCUMFERENCE : " + circum);

        }
    }

}
