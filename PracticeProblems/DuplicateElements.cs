using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class DuplicateElements
    {
        public void CountDuplicateElements()
        {
            int count = 0;
            Console.WriteLine("Enter the size of array");
            int n =Convert.ToInt32(Console.ReadLine());
            int[] array= new int[n];
            Console.WriteLine("Enter the elements");
            for(int i=0;i<array.Length;i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            var dict = new Dictionary<int, int>();
            foreach (int value in array)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict[value] = 1;
                }
            }
            foreach (var data in dict)
            {
                if (data.Value > 1)
                    count += data.Value;
            }
            Console.WriteLine("Total no of Duplicates: " + count);



        }
    }
}
