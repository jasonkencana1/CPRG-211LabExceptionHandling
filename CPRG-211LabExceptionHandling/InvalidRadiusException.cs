using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211LabExceptionHandling
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() : base("The radius is greater than 0") { }

        public InvalidRadiusException(double radius)
        {
            Console.WriteLine("The radius: " + radius + " is not valid");
        }
    }
}
