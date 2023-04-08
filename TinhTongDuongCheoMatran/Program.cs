using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongDuongCheoMatran
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }

            Console.WriteLine("Sum of main diagonal elements: " + sum);

        }
    }
}
