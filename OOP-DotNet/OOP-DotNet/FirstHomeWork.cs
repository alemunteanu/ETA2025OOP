using System;

namespace OOP_DotNet
{
    public class FirstHomeWork
    {
        public string GetUserDetails(string firstName, string lastName, int age, string gender)
        {
            // Calculate age in 20 years
            int ageIn20Years = age + 20;

            // Create the output string
            string result = $"\nYour details are as follows:\n" +
                            $"- First Name: {firstName}\n" +
                            $"- Last Name: {lastName}\n" +
                            $"- Gender: {gender}\n" +
                            $"\nYou will be {ageIn20Years} years old in 20 years!";
            return result;
        }
    }
}