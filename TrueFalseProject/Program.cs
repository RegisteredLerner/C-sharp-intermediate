using System;

namespace TrueOrFalse
{
  class Program
  {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            string[] questions = {"Każdy rok podzielny przez 4 jest przestepny",
            "0,999 (nieskonczenie wiele dziewiątek) jest równe 1",
            "Antarktyda jest pustynią",
            "Woda zawsze wrze w 100stopniach celsjusza",
            "Kiwi umie latać"};
            bool[] answers = { false, true, true, false, true };
            bool[] responses = new bool[answers.Length];
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("NOT EQUAL");
            }
            int askingIndex = 0;
            foreach (string quest in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(quest);
                Console.WriteLine("TRUE OF FALSE?");
                input = Console.ReadLine();
                input = input.ToLower();
                if (input == "true" || input == "false")
                {
                    isBool = true;
                }
                else
                {
                    isBool = false;
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                }
                while (!isBool)
                {
                    input = Console.ReadLine();
                    input = input.ToLower();
                    if (input == "true" || input == "false")
                    {
                        isBool = true;
                    }
                    else
                    {
                        isBool = false;
                        Console.WriteLine("Please respond with 'true' or 'false'.");
                    }
                }
                if (input == "true")
                {
                    inputBool = true;
                }
                else
                {
                    inputBool = false;
                }
                responses[askingIndex] = inputBool;
                askingIndex++;

            }
            int scoringIndex = 0;
            int score = 0;
            foreach (bool answeri in answers)
            {
                bool responded = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}.Input:{responded}| Answer: {answeri}");
                if (responded == answeri)
                {
                    score++;
                }
                scoringIndex++;
            }
            if (score > 0)
            {
                Console.WriteLine($"You got {score} out of 5 correct");
            }
            else
            {
                Console.WriteLine("You got nothing amazing");
            }
            

        }
  }
}
