using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuiz.Logic
{
    class Math : Quiz
    {
        public override void Quizzes()
        {
            int firstmathquestion;
            Console.WriteLine("Math Quiz\n These are the questions:\n");
            Console.WriteLine("1. What is the product of 20 and 25?");
            firstmathquestion = Convert.ToInt32(Console.ReadLine());
            if (firstmathquestion == 500)
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: 500");
            }
            int secondmathquestion;
            Console.WriteLine("2. What is the sum of 1025 and 1250?");
            secondmathquestion = Convert.ToInt32(Console.ReadLine());
            if (secondmathquestion == 2275)
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: 2275");
            }
            int thirdmathquestion;
            Console.WriteLine("3. What is the difference of 2058 and 1253?");
            thirdmathquestion = Convert.ToInt32(Console.ReadLine());
            if (thirdmathquestion == 805)
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: 805");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for answering the Quiz");
            Console.ReadKey();
        }
    }
}
