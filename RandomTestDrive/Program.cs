using System;

namespace RandomTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new instance of Random, generating a random int,
            // and writing to the console.
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            // Specifying the maximum value o to get random numbers from 0 up to -
            // but not including  - the maximum value. A max value of 10 generates
            // numbers from 0 to 9.

            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            // Die roll simulation with min 1 and max 7 
            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);

            // NextDouble method generates double values.
            // Returns a random floating-point number that is
            // gerater or eaqual to 0.0 and less than 1.0.
            double randomDouble = random.NextDouble();

            Console.WriteLine(randomDouble * 100);

            // Using casting to convert the random double to other types.
            Console.WriteLine((float)randomDouble * 100F);
            Console.WriteLine((decimal)randomDouble * 100M);

            // Using max value of 2 to simulate a coin toss.
            // This generates a random value of either 0 or 1.
            // Using special Convert class which has a static ToBoolean
            // method that will convert it to Boolean value.
            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);

            
        }
    }
}
