using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Calculator
    {
        private static double age;
        private static double creditScore;
        private static double compoundInterest;
        private static bool isMale = false;

        public static void CalculateCompoundInterest()
        {
            bool isCorrect = false;
            string ageInput = "";
            string creditScoreInput = "";
            string genderInput = "";
            while(isCorrect==false)
            {
                Console.WriteLine("What is your gender?");
                genderInput = Console.ReadLine();
                if (genderInput == "male" || genderInput =="female")
                {
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Please enter male or female.");
                }
            }
            if(genderInput == "male")
            {
                isMale = true;
            }
            isCorrect = false;
            while(isCorrect == false)
            {
                Console.WriteLine("What is your age?");
                ageInput = Console.ReadLine();
                if(double.TryParse(ageInput,out age))
                {
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Please enter only a number for your age.");
                }
            }
            isCorrect = false;
            while(isCorrect == false)
            {
                Console.WriteLine("What is your credit score?");
                creditScoreInput = Console.ReadLine();
                if(double.TryParse(creditScoreInput,out creditScore))
                {
                    if(creditScore>=300 && creditScore<=850)
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 300 and 850.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter only a number for your credit score.");
                }
            }

            
        }
    }   
}
