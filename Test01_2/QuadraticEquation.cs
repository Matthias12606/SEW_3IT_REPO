using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01_2
{
    public class QuadraticEquation
    {
        public static void SolveReal(double a, double b, double c, out double? x1Real, out double? x2Real)
        {
            double sqrtpart = b * b - 4 * a * c;

            x1Real = null;
            x2Real = null;
            if (sqrtpart >= 0)
            {
                x1Real = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2Real = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
            }
        }

        public static void SolveComplex(double a, double b, double c, out double? xReal, out double? img)
        {
            double sqrtpart = b * b - 4 * a * c;

            xReal = null;
            img = null;
            if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                xReal = -b / (2 * a);
                img = System.Math.Sqrt(sqrtpart) / (2 * a);
            }
        }

    }

}
