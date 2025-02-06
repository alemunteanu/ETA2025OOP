using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DotNet.Tests
{
    public class SecondHomeworkTests
    {
        [Test]
        public void ComputeAgeInXYears_ShouldReturnCorrectAge()
        {
            // Arrange
            Person.Age = 30;

            // Act
            int futureAge = Person.ComputeAgeInXYears(20);

            // Assert
            Assert.AreEqual(50, futureAge);
        }

        [Test]
        public void DisplayUserDetails_ShouldOutputCorrectDetails()
        {
            // Arrange
            Person.FirstName = "Alexandra";
            Person.LastName = "Munteanu";
            Person.Age = 30;
            Person.Gender = "Female";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Person.DisplayUserDetails(20);

                // Assert
                string expectedOutput =
                    "The person's details are as follows:\r\n" +
                    "- First Name: John\r\n" +
                    "- Last Name: Doe\r\n" +
                    "- Gender: Male\r\n" +
                    "You will be 50 years old in 20 years!\r\n";

                Assert.IsTrue(sw.ToString().Contains(expectedOutput));
            }
        }
    }
}
