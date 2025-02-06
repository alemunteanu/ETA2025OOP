namespace OOP_DotNet.Tests
{
    public class FirstHomeWorkTests
    {
        [Test]
        public void GetUserDetails_ReturnsCorrectDetails()
        {
            // Arrange
            var homework = new FirstHomeWork();
            string firstName = "Alexandra";
            string lastName = "Munteanu";
            int age = 30;
            string gender = "Female";

            // Act
            string result = homework.GetUserDetails(firstName, lastName, age, gender);

            Console.WriteLine(result);

            // Assert
            string expectedOutput = "\nYour details are as follows:\n" +
                                    "- First Name: Alexandra\n" +
                                    "- Last Name: Munteanu\n" +
                                    "- Gender: Female\n" +
                                    "\nYou will be 50 years old in 20 years!";

            Assert.AreEqual(expectedOutput, result);
        }
    }
}
