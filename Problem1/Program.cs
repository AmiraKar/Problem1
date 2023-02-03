using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {

        // get count of maximum consecutive numbers
        static int getmaxLength(int[] arr, int num)
        {

            int count = 0;
            int result = 0;

            for (int i = 0; i < num; i++)
            {

                if (arr[i] == 0)
                    count = 0;

                else
                {
                    count++;
                    result = Math.Max(result, count);
                }
            }

            return result;
        }
 
              static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };

            int num = arr.Length;

            Console.WriteLine(getmaxLength(arr, num));
        }
    }
}