using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class UniqueElements
    {
        public void FindUniqueElements()
        {
            Console.WriteLine("Enter Size of array");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] array= new int[n];
            Console.WriteLine("Enter The Elements:");
            for(int i=0;i<array.Length;i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            HashSet<int> uniqueElements = new HashSet<int>();
            foreach (int element in array)
            {
                if (!uniqueElements.Contains(element))
                {
                    uniqueElements.Add(element);
                }
            }
            Console.WriteLine("Unique elements:");
            foreach (int element in uniqueElements)
            {
                Console.WriteLine(element + " ");
            }
        }
    }
}
