class Program
{
    static void Main(string[] args)
    {
        // Get the user's first and last name.
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        // Display the user's name as the assignment demonstrates.
        Console.WriteLine($"\nYour name is {lname}, {fname} {lname}.");

    }
}