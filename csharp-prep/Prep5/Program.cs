class Program
{
    static void Main(string[] args)
    {
        // Functions to be called.
        DisplayWelcome();
        string user_name = PromptUserName();
        int favorite_number = PromptUserNumber();
        int birth_year;
        PromptUserBirthYear(out birth_year);
        int square_number = SquareNumber(favorite_number);
        DisplayResults(user_name, square_number, birth_year);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favorite_number = int.Parse(Console.ReadLine());
        return favorite_number;
    }

    static void PromptUserBirthYear(out int birth_year)
    {
        Console.Write("Please enter the year you were born: ");
        birth_year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int favorite_number)
    {
        int square_number = favorite_number * favorite_number;
        return square_number;
    }
    static void DisplayResults(string user_name, int square_number, int birth_year)
    {
        Console.Write($"{user_name}, the square of your number is: {square_number}\n{user_name}, you will turn {2025 - birth_year} this year.");
    }
}