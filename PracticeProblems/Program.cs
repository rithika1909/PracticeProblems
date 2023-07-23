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
                Console.WriteLine("Enter input to be executed\n 1.Find maximum and minimum element in array\n 2.Find count of duplicate elements\n 3.Print Unique Elements\n 4.Print Frequency of elements\n 5.Print Pattern\n 6.Print Pattern1\n 7.Print Reversed\n 8.Print Sum Of digits in number\n 9.Convert FirstWord to Capital");
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
                    case 5:
                        PrintPattern printPattern = new PrintPattern();
                        printPattern.ShowPattern();
                        break;
                    case 6:
                        PrintPattern1 printPattern1 = new PrintPattern1();
                        printPattern1.DisplayPattern();
                        break;
                    case 7:
                        ReverseString reverseString = new ReverseString();
                        reverseString.PrintReverseString();
                        break;
                    case 8:
                        SumOfDigits sumOfDigits = new SumOfDigits();
                        sumOfDigits.FindSumOfDigits();
                        break;
                    case 9:
                        ConvertWord convertWord = new ConvertWord();
                        convertWord.ConvertWordoCapital();
                        break;
                    default:
                        flag = false;
                        break;


                }

            }
        }
    }
}