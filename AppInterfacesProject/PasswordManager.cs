using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        public string HeaderSymbol { get; }
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
            HeaderSymbol = "-";

        }
        public void Display()
        {
            Console.WriteLine("Password");
            Console.WriteLine(String.Concat(Enumerable.Repeat(HeaderSymbol, 12)));
            if (Hidden is false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                int len = Password.Length;
                int count = 0;
                string temp = "";
                while (count < len)
                {
                    temp += "*";
                    count++;
                }
                Console.WriteLine(temp);
            }
        }
        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
        
  }
}