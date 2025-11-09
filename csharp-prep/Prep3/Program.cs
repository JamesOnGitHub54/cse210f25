class Program
{
    static void Main(string[] args)
    {
        // User's magic number is obtained.
        // Console.Write("What is the magic number?");
        // int magic_number = int.Parse(Console.ReadLine());

        // Magic number is made.
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);

        // Guess is established and differs from the magic number.
        int guess = magic_number + 1;

        // Loop is followed until magic number is guessed.
        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            // Result of number found.
            else Console.WriteLine("You guessed it!");
        }
    }
}