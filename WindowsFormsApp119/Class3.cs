using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp119
{
    class cTarkib
    {

        public int n
        {
            get;
            set;
        }

        public int x
        {
            get;
            set;
        }

        public int combinition(delFac f)
        {
            return (int)(f(n) / (f(x) * f(n - x)));
        }
    }
}
