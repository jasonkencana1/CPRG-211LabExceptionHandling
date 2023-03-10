using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211LabExceptionHandling
{
    internal class Circle
    {
        public double Radius;

/*        public double Area
        {
            get
            {
                return Math.PI * (Radius * Radius);
            }
        }*/

        public void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                this.Radius = radius;
                throw new InvalidRadiusException(radius);
            }
            else
            {
                this.Radius = radius;
                throw new InvalidRadiusException();
            }
        }

        public string ToString()
        {
            return "Radius: " + Radius;
        }
    }
}
