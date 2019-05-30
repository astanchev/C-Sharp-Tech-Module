using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool passLenght = PasswordLenght(password);
            bool passLettersAndDigits = PasswordLettersAndDigits(password);
            bool passTwoDigits = PasswordTwoDigits(password);
            PasswordValidation(passLenght, passLettersAndDigits, passTwoDigits);
        }

        static bool PasswordLenght(string password)
        {
            bool lenght = false;
            if (password.Length > 5 && password.Length < 11)
            {
                lenght = true;
            }
            return lenght;
        }

        static bool PasswordLettersAndDigits(string password)
        {
            bool lettersAndDigits = true;
            for (int i = 0; i < password.Length; i++)
            {
                bool isNumber = password[i] >= 48 && password[i] <= 57;
                bool isBigLetter = password[i] >= 65 && password[i] <= 90;
                bool isSmalLetter = password[i] >= 97 && password[i] <= 122;
                if (!isNumber && !isBigLetter && !isSmalLetter)
                {
                    lettersAndDigits = false;
                }
            }
            return lettersAndDigits;
        }

        static bool PasswordTwoDigits(string password)
        {
            bool twoDigits = false;
            int countDigits = 0;
            for (int i = 0; i < password.Length; i++)
            {
                bool isNumber = password[i] >= 48 && password[i] <= 57;
                if (isNumber)
                {
                    countDigits++;
                }
            }
            if (countDigits>=2)
            {
                twoDigits = true;
            }
            return twoDigits;
        }

        static void PasswordValidation(bool passLenght,
                                        bool passLettersAndDigits,
                                        bool passTwoDigits)
        {
            if (passLenght && passLettersAndDigits && passTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!passLenght)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!passLettersAndDigits)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!passTwoDigits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
    }
}
