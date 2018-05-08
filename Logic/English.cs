using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuiz.Logic
{
    class English : Quiz
    {
        public override void Quizzes()
        {
            string firstenglishquestion;
            Console.WriteLine("English Quiz\n These are the questions:\n");
            Console.WriteLine("1. What is the substitute of Noun?");
            firstenglishquestion = Console.ReadLine();
            if (firstenglishquestion.ToUpper() == "PRONOUN")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Pronoun");
            }
            string secondfilipinoquestion;
            Console.WriteLine("2. What is an action word?");
            secondfilipinoquestion = Console.ReadLine();
            if (secondfilipinoquestion.ToUpper() == "VERB")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Verb");
            }
            string thirdfilipinoquestion;
            Console.WriteLine("3. What is a person, place or thing?");
            thirdfilipinoquestion = Console.ReadLine();
            if (thirdfilipinoquestion.ToUpper() == "NOUN")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Noun");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for answering the Quiz");
            Console.ReadKey();
        }
    }
}
