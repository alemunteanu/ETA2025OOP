namespace OOP_DotNet
{
    public static class Person
    {
        // Static attributes to store user details
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static int Age { get; set; }
        public static string Gender { get; set; }

        // Method to compute the age in X years
        public static int ComputeAgeInXYears(int years)
        {
            return Age + years;
        }

        // Method to display user details
        public static void DisplayUserDetails(int years)
        {
            int futureAge = ComputeAgeInXYears(years);

            Console.WriteLine("The person's details are as follows:");
            Console.WriteLine($"- First Name: {FirstName}");
            Console.WriteLine($"- Last Name: {LastName}");
            Console.WriteLine($"- Gender: {Gender}");
            Console.WriteLine($"You will be {futureAge} years old in {years} years!");
        }
    }

    class SecondHomework
    {
        public static void Main()
        {
            int age = 0;
            // Prompt user for input
            Console.Write("Please input your First name: ");
            Person.FirstName = Console.ReadLine();

            Console.Write("Please input your Last name: ");
            Person.LastName = Console.ReadLine();

            Console.Write("Please input your age: ");

            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }
            Person.Age = age;

            Console.Write("Please input your gender: ");
            Person.Gender = Console.ReadLine();

            // Display user details and compute future age
            Person.DisplayUserDetails(20); // Example: 20 years into the future

            // Wait for user to close the console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
