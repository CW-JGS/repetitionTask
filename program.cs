using System;

namespace RepetitionTask {
    class Program {
        static void Main(string[] args)
        {
            // task one
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            // Task Two
            int j = 0;
            while (j <= 20)
            {
                Console.WriteLine(j);
                j += 2;
            }
            // Task three
            int magicNumber = 5;
            while (true)
            {
                Console.Write("Guess a number between 0 and 5 \n Enter your guess : ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == magicNumber)
                {
                    Console.WriteLine($" Correct - {guess} is {magicNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine($" Incorrect - {guess} is not the magic number");
                }
            }
            // Task Four

            Console.Write("\n Enter a number : ");
            int userInputNumber = int.Parse(Console.ReadLine());
            for (int k = 0; k <= userInputNumber; k++)
            {
                Console.WriteLine(k);
            }
            // Task Five
            string answer = "IT GETS WET";
            while (true)
            {
                Console.Write(" What happens when you throw a yellow rock into the red sea? : ");
                string guess = Console.ReadLine();
                if (guess.ToUpper() == answer)
                {
                    Console.WriteLine(" Correct");
                    break;
                }
                else
                {
                    Console.WriteLine(" Incorrect - Guess again");
                }
            };
            // Task Six
            int secretNumber = 653;
            int noOfGuesses = 10;
            while (true)
            {
                if (noOfGuesses != 0)
                {
                    Console.Write(" Guess a number between 0 - 1000 : ");
                    int secretNumberGuess = int.Parse(Console.ReadLine());
                    if (secretNumberGuess == secretNumber)
                    {
                        Console.WriteLine("Success");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("failure - {0}", noOfGuesses - 1);
                        noOfGuesses -= 1;
                    }

                }
                else
                {
                    Console.WriteLine("you have run out of guesses");
                }
            }
            // Task Six + 1
            Random rand = new Random();
            int randomSecretNumber = rand.Next(0, 1000);
            int noOfGuessesRand = 10;

            if (noOfGuessesRand != 0)
            {

            } else
            {

            }
            // Task Seven -- FIZZBUZZ
            int fizzBuzzCounter = 1;
            while (fizzBuzzCounter < 101) {
                if (fizzBuzzCounter % 3 == 0 && fizzBuzzCounter % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if(fizzBuzzCounter % 3 == 0 && fizzBuzzCounter % 5 != 0)
                {
                    Console.WriteLine("fizz");
                } else if(fizzBuzzCounter % 3 != 0 && fizzBuzzCounter % 5 == 0)
                {
                    Console.WriteLine("buzz");
                } else
                {
                    Console.WriteLine(fizzBuzzCounter);
                }
                fizzBuzzCounter += 1;
            }

        }

    }
}
