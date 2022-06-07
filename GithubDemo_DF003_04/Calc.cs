using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubDemo_DF003_04
{

    public interface ICalc
    {
        int Add(int x, int y);
        int Multiply(int x, int y);
        int Divide(int x, int y);
        int Subtract(int x, int y);
    }

    public class Calc : ICalc
    {
        public int Add(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public int Multiply(int x, int y)
        {
            return (x * y);
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
