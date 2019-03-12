using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpoLab5
{
    class Program
    {
        static double Conv(float x)
        {
            return x*2.54;
        }

        static bool check (int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        static int max(int[] array)
        {
            int max;
            max = array[0];
            for (int i=1; i<array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            return max;
        }

        static int rem(int a, int b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            int tmp;
        }
    }
}
