using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211LabExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius1 = 0;
            double radius2 = -10;
            double radius3 = 10;

            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            Circle circle3 = new Circle();

            try
            {
                
                circle1.SetRadius(radius1);  
            }

            catch (InvalidRadiusException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something else went wrong");
            }

            try
            {
                
                circle2.SetRadius(radius2);
            }

            catch (InvalidRadiusException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                
                circle3.SetRadius(radius3);
                
            }

            catch (InvalidRadiusException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(circle3.ToString());
        }
    }
}
