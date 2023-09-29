using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp119
{
    class cMath
    {

        public static double Factorial(int n)
        {
            double s = 1;

            for (int i = n; i >= 1; i--)
                s *= 1;
            return s;
        }
    }
}
