using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class LowerSum
    {
        public void CalLowerSum()
        {
            Console.WriteLine("Enter size of array");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] array= new int[n];
            Console.WriteLine("Enter The Elements:");
            for (int i= 0;i<array.Length;i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());

            }
            int low1 = int.MaxValue;
            int low2 = int.MaxValue;

            foreach(int item in array)
            {
                if (item<low1)
                {
                    low2 = low1;
                    low1 = item;
                }
                else if (item<low2)
                {
                    low2 = item;
                }
            }
            int sum = low1 + low2;
            Console.WriteLine("Two lowest numbers: " + low1 + " ," + low2);
            Console.WriteLine("Sum of the two lowest numbers: " + sum);

        }
    }
}
