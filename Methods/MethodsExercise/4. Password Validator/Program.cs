using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	"Password must be between 6 and 10 characters"
            //•	"Password must consist only of letters and digits"
            //•	"Password must have at least 2 digits"

            string password = Console.ReadLine();

            bool passwordIsLongEnough = GetPasswordLength(password);
            bool onlyLetterAndDigitsInPassword = CheckForSpecialSymbols(password);
            bool atLeastTwoDigitsInPassword = CountDigits(password);

            if (!passwordIsLongEnough)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!onlyLetterAndDigitsInPassword)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!atLeastTwoDigitsInPassword)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (passwordIsLongEnough && onlyLetterAndDigitsInPassword && atLeastTwoDigitsInPassword)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CountDigits(string pass)
        {
            bool passwordIsValid = false;
            int digitsCount = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    digitsCount++;
                }
            }
            if (digitsCount>=2)
            {
                passwordIsValid = true;
            }
            return passwordIsValid;
        }

        static bool CheckForSpecialSymbols(string pass)
        {
            bool passwordIsValid = true;
            for (int i = 0; i < pass.Length; i++)
            {
                if (!(char.IsDigit(pass[i]) || char.IsLetter(pass[i])))
                {
                    passwordIsValid = false;
                }
                
            }
            return passwordIsValid;
        }

        static bool GetPasswordLength(string pass)
        {
            bool passwordIsValid =  pass.Length >= 6 && pass.Length <= 10;
            return passwordIsValid;
        }
    }
}
