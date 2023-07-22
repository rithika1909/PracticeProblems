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
                Console.WriteLine("Enter input to be executed\n 1.Find maximum and minimum element in array");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        MaxMin maxmin = new MaxMin();
                        maxmin.FindMaxMin();
                        break;
                    default:
                        flag = false;
                        break;


                }

            }
    }
}