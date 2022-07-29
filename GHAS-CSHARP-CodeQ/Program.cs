using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GHAS_CSHARP_CodeQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int d=5;
            int n = 6;
            int res = Test(d,n);

            string userName = Console.ReadLine();
            Regex pwd= new Regex(userName);

        }

        static int Test(int x, int y)
        {
            if (x >= y) return x / y;
            if (x<y) return y / x; 

            int z = x + y;

            return z;
        }
    }
}
