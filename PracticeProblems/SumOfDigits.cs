using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class SumOfDigits
    {
        public void FindSumOfDigits()
        {
            Console.WriteLine("Enter Number:");
            int n= Convert.ToInt32(Console.ReadLine());
            int sum = 0, r;
            while(n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n /= 10;
            }
            Console.WriteLine("the sum of digits is : " + sum);
        }
    }
}
