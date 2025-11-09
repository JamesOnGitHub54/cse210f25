class Program
{
    static void Main(string[] args)
    {
        // Setting variables and asking user for grade percentage.
        string letter;
        Console.Write("What is your grade percentage? ");
        int grade_percentage = int.Parse(Console.ReadLine());

        // Determine the letter grade from user grade percentage.
        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            letter = "B";
        }
        else if (grade_percentage >= 70)
        {
            letter = "C";
        }
        else if (grade_percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Display letter grade.
        Console.WriteLine($"Your grade is: {letter}");
    }
}