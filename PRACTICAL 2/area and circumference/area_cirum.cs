using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_and_circumference
{
    internal class area_cirum
    {
        public double area (double r) 
        {
            double  pi = 3.142;
            
            double area;

            area = pi * (r * r); 
           
            return area;
        }

        public  double circum(double r) 
        {
            double pi = 3.142;

            double area;

            double circum = 2 * pi * r;

            return circum;

            

        }
    }
}
