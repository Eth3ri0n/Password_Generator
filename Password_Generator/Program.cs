using Ask_Password_Generator;
using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_PASSWORDS = 10;

            int PasswordLength = tools.AskPositiveNumberNotNull("Enter the length of the password: ");

            Console.WriteLine();
            int passwordPreference = tools.AskNumberBetween("What kind of password do you want ? : \n" +
                "1 - Only with lowercase characters \n" +
                "2 - Only with lowercase and uppercase characters \n" +
                "3 - Only with characters and numbers \n" +
                "4 - Characters, numbers and special characters \n" +
                "You choice : ", 1, 4);

            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string upperCase = lowerCase.ToUpper();
            string numbers = "0123456789";
            string specialCharacters = "{~[-|_^!@#$%^&*()_+]=£%*µ/!§+}";
            string password = "";
            string alphabet;

            Random random = new Random();

            // Generate the password
            if (passwordPreference == 1)
            {
                alphabet = lowerCase;
            }
            else if (passwordPreference == 2)
            {
                alphabet = lowerCase + upperCase;
            }
            else if (passwordPreference == 3)
            {
                alphabet = lowerCase + upperCase + numbers;
            }
            else
            {
                alphabet = lowerCase + upperCase + numbers + specialCharacters;
            }

            int alphabetLength = alphabet.Length;
            int index = random.Next(0, alphabetLength);
            password += alphabet[index];

            // Display the password
            for (int i = 0; i < NUMBER_OF_PASSWORDS; i++)
            {
                password = "";
                for (int j = 1; j < PasswordLength; j++)
                {
                    index = random.Next(0, alphabetLength);
                    password += alphabet[index];
                }

                Console.WriteLine("Generated password: " + password);
            }
        }
    }
}