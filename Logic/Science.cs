using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuiz.Logic
{
    class Science : Quiz
    {
        public override void Quizzes()
        {
            string firstsciencequestion;
            Console.WriteLine("Science Quiz\n These are the questions:\n");
            Console.WriteLine("1. What is the shape of the Earth?");
            firstsciencequestion = Console.ReadLine();
            if (firstsciencequestion == "Sphere")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Sphere");
            }
            string secondsciencequestion;
            Console.WriteLine("2. What is the third planet in the Solar System?");
            secondsciencequestion = Console.ReadLine();
            if (secondsciencequestion == "Earth")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Earth");
            }
            string thirdsciencequestion;
            Console.WriteLine("3. What is the biggest planet in the Solar System?");
            thirdsciencequestion = Console.ReadLine();
            if (thirdsciencequestion == "Jupiter")
            {
                Console.WriteLine("You are Correct!");
            }
            else
            {
                Console.WriteLine("You are Incorrect, The Answer is: Jupiter");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for answering the Quiz");
            Console.ReadKey();
        }
    }
}
