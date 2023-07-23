using System;
namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input to be executed\n 1.Find maximum and minimum element in array\n 2.Find count of duplicate elements\n 3.Print Unique Elements\n 4.Print Frequency of elements");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        MaxMin maxmin = new MaxMin();
                        maxmin.FindMaxMin();
                        break;
                    case 2:
                        DuplicateElements duplicateElements = new DuplicateElements();
                        duplicateElements.CountDuplicateElements();
                        break;
                    case 3:
                        UniqueElements uniqueElements = new UniqueElements();
                        uniqueElements.FindUniqueElements();
                        break;
                    case 4:
                        Frequency frequency = new Frequency();
                        frequency.FindFrequency();
                        break;
                    default:
                        flag = false;
                        break;


                }

            }
        }
    }
}