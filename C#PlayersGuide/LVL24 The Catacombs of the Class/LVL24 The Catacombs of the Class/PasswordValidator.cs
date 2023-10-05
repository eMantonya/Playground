using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVL24_The_Catacombs_of_the_Class
{
    internal class PasswordValidator
    {
        private string _password;

        public PasswordValidator()
        {
            _password = ValidatePass();
        }

        public string Password => _password;

        private string ValidatePass()
        {
            while (true)
            {
                Console.WriteLine("Please enter a password:\n6 - 13 characters in length -- Must contain at least 1 uppercase letter, 1 lowercase letter, and 1 number.");
                Console.WriteLine("MUST NOT CONTAIN \"T\" or \"&\"");
                string pass = Console.ReadLine();
                bool validPass = true;               
                if (pass.Length > 13 || pass.Length < 6)
                {
                    validPass = false;
                    Console.WriteLine("Password length incorrect..");
                    continue;
                }
                foreach (char c in pass)
                {
                    if (c == 'T')
                    {
                        validPass = false;
                        Console.WriteLine("I SAID NO \"T\"!!!");
                        continue;
                    }
                    else if (c == '&')
                    {
                        validPass = false;
                        Console.WriteLine("I SAID NO \"&\"!!!");
                        continue;
                    }                                     
                }
                bool numInPass = false;
                bool upperCharInPass = false;
                bool lowerCharInPass = false;
                foreach (char ch in pass)
                {
                    if (!char.IsDigit(ch) && ch == char.ToUpper(ch))
                    {
                        upperCharInPass = true;
                    }
                    if (!char.IsDigit(ch) && ch == char.ToLower(ch))
                    {
                        lowerCharInPass = true;
                    }
                    if (char.IsDigit(ch))
                    {
                        numInPass = true;
                    }
                }
                if (validPass && numInPass && upperCharInPass && lowerCharInPass)
                {
                    return pass;
                }
                else 
                { 
                    Console.WriteLine("Try again..");
                    continue;
                }
            }
        }
    }
}
