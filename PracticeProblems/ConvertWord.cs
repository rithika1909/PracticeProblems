﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class ConvertWord
    {
        public void ConvertWordoCapital()
        {
            Console.WriteLine("Enter the sentence:");
            string input = Console.ReadLine();
            string result = "";
            bool isFirstLetter = true;
            foreach (char ch in input)
            {
                if (isFirstLetter && char.IsLetter(ch))
                {
                    result += char.ToUpper(ch);
                    isFirstLetter = false;
                }
                else
                {
                    result += ch;
                }

                if (char.IsWhiteSpace(ch))
                {
                    isFirstLetter = true;
                }
            }
            Console.WriteLine("Converted sentence:");
            Console.WriteLine(result);
        }
    }
    
}
