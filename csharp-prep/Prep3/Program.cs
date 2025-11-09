class Program
{
    static void Main(string[] args)
    {
        // User's magic number is obtained.
        Console.Write("What is the magic number?");
        int magic_number = int.Parse(Console.ReadLine());

        // Guess is established and differs from the magic number.
        int guess = magic_number + 1;

        // Loop is followed until magic number is guessed.
        while (guess != magic_number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else Console.WriteLine("You guessed it!");
        }
    }
}