namespace OOP_DotNet
{
    public class Multimi
    {

        [Test]
        public void Test1()
        {
            Dictionary<string, string> objects = new Dictionary<string, string>
        {
            { "object", "laptop" },
            { "fruit", "apple" },
            { "sport", "snowboard" }
        };

            //foreach (var obj in objects)
            //{
            //    Console.WriteLine($"The key is {obj.Key}");
            //    Console.WriteLine($"The value is {obj.Value}");
            //}

            Dictionary<string, List<string>> classifications = new Dictionary<string, List<string>>();
            List<string> citiesOfRomania = new List<string> { "Bucharest", "Cluj-Napoca", "Timisoara" };
            List<string> citiesOfFrance = new List<string> { "Paris", "Lyon", "Marseille" };
            List<string> citiesOfGermany = new List<string> { "Berlin", "Munich", "Hamburg" };

            //classifications.Add("Romania", citiesOfRomania);
            classifications["Romania"] = citiesOfRomania;
            classifications["France"] = citiesOfFrance;
            classifications["Germany"] = citiesOfGermany;

            foreach (var key in classifications.Keys)
            {
                Console.WriteLine($"The country is: {key}");
                Console.WriteLine($"Cities are: " + string.Join(", ", classifications[key]));
            }
        }



    }
}
