class Program
{
    static void Main(string[] args)
    {
        // Set user number and list.
        int user_number = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Numbers will continue to be added until 0 closes loop.
        while (user_number != 0)
        {
            Console.Write("Enter number: ");
            user_number = int.Parse(Console.ReadLine());
            if (user_number != 0)
            {
                numbers.Add(user_number);
            }
        }

        // Sum of numbers.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"Sum: {sum}");
    }
}