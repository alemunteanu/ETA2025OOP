namespace OOP_DotNet.ThirdHomework
{
    public class Person
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        private List<string> Skills { get; set; } = new List<string>();

        // IsOld() method using if-else-if statements
        public void IsOld()
        {
            if (Age >= 100)
            {
                Console.WriteLine("You are ancient!");
            }
            else if (Age >= 50)
            {
                Console.WriteLine("You are old!");
            }
            else
            {
                Console.WriteLine("You are still young!");
            }
        }

        // ShowGender() method using switch statement
        public void ShowGender()
        {
            switch (Gender)
            {
                case "Male":
                    Console.WriteLine("You are a male!\r\n");
                    break;
                case "Female":
                    Console.WriteLine("You are a female!\r\n");
                    break;
                default:
                    Console.WriteLine("You haven't specified your gender!\r\n");
                    break;
            }
        }

        // Method to add a skill to the person
        public void AddSkill(string skill)
        {
            Skills.Add(skill);
            Console.WriteLine($"Added a new skill: {skill}");
        }

        // Method to display all skills of the person
        public void DisplaySkills()
        {
            Console.WriteLine("The person has the following skills:");
            foreach (var skill in Skills)
            {
                if (skill == "Ninja")
                {
                    continue; // Skip displaying "Ninja"
                }
                if (skill == "CIA")
                {
                    Console.WriteLine("\r\n>>>>>>>> Classified information, no further skills are displayed! <<<<<<<<");
                    break; // Stop displaying further skills
                }
                Console.Write($"{skill}; ");
            }
            Console.WriteLine();
        }

        // CountTo() method using while or do-while loop
        public void CountTo(int number)
        {
            int i = 1;
            Console.WriteLine($"Counting to {number}:");

            while (i <= number)
            {
                if (i == 10)
                {
                    Console.WriteLine("\nNumber skipped!");
                    i++;
                    continue;
                }

                if (i == 99)
                {
                    Console.WriteLine("\nCannot count past 99!");
                    break;
                }

                Console.Write($"{i}; ");
                i++;
            }

            Console.WriteLine();
        }

        // Example usage
        public static void Main(string[] args)
        {
            Person person = new Person();

            // Example 1
            person.Age = 120;
            person.Gender = "Male";
            person.IsOld();         // Output: You are ancient!
            person.ShowGender();    // Output: You are a male!

            // Example 2
            person.Age = 45;
            person.Gender = "Female";
            person.IsOld();         // Output: You are still young!
            person.ShowGender();    // Output: You are a female!

            // Example 3
            person.Age = 60;
            person.Gender = "";
            person.IsOld();         // Output: You are old!
            person.ShowGender();    // Output: You haven't specified your gender!

            // Adding skills
            person.AddSkill("Cooking");
            person.AddSkill("Photography");
            person.AddSkill("Programming");
            person.AddSkill("Testing");
            person.AddSkill("Ninja");
            person.AddSkill("Swimming");
            person.AddSkill("CIA");
            person.AddSkill("Dancing");

            // Displaying skills
            person.DisplaySkills();

            // Counting to 100 with specific conditions
            person.CountTo(100);
        }
    }
}
