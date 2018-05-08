using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuiz.Logic
{
    class Filipino : Quiz
    {
        public override void Quizzes()
        {
            string firstfilipinoquestion;
            Console.WriteLine("Science Quiz\n These are the questions:\n");
            Console.WriteLine("1. What is the national language of the Philippines?");
            firstfilipinoquestion = Console.ReadLine();
            if (firstfilipinoquestion == "Filipino")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Filipino");
            }
            string secondfilipinoquestion;
            Console.WriteLine("2. What is the capital of the Philippines?");
            secondfilipinoquestion = Console.ReadLine();
            if (secondfilipinoquestion == "Manila")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Manila");
            }
            string thirdfilipinoquestion;
            Console.WriteLine("3. What is the biggest city in the Philippines?");
            thirdfilipinoquestion = Console.ReadLine();
            if (thirdfilipinoquestion == "Quezon City")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Quezon City");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for answering the Quiz");
            Console.ReadKey();
        }
    }
}
