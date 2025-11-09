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

        // End message of course completion result with letter grade.
        if (grade_percentage >= 70)
        {
            Console.WriteLine($"You have earned the letter grade of: {letter}. Congratulations! You have passed the course!");
        }
        else Console.WriteLine($"You have earned the letter grade of: {letter}. Unfortunately, you have failed the course. You can do better next time!");
    }
}