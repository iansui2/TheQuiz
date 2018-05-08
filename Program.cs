using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuiz.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            start:
            Console.WriteLine("Welcome\n This is a Collection of Quizzes\n CHOOSE:\n");
            Console.WriteLine(" A. Math\n B. Science\n C. Filipino\n D. English\n");
            Console.WriteLine("You Choose");
            response = Console.ReadLine();

            Console.WriteLine("\n");

            Quiz selectMath = new Math();
            Quiz selectScience = new Science();
            Quiz selectFilipino = new Filipino();
            Quiz selectEnglish = new English();

            if (response == "A")
            {
                selectMath.Quizzes();
            }
            else if (response == "B")
            {
                selectScience.Quizzes();
            }
            else if (response == "C")
            {
                selectFilipino.Quizzes();
            }
            else if (response == "D")
            {
                selectEnglish.Quizzes();
            }
            else
            {
                {
                    if (string.IsNullOrWhiteSpace(response))
                    {
                        Console.WriteLine("No Letter");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Letter");
                    }

                }
            }
            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
