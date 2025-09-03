using System;

namespace CaesarCipher
{
  class Program
  {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f',
          'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
          's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            Console.WriteLine(alphabet.Length);
            Console.WriteLine("Type secret message");
            string input = Console.ReadLine();
            input = input.ToLower();
            char[] secretMessage = input.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char temp = secretMessage[i];
                int indexed = Array.IndexOf(alphabet, temp);
                int position = (indexed + 3)%alphabet.Length;
                char letter = alphabet[position];
                encryptedMessage[i] = letter;

            }
            string encrypt = String.Join("", encryptedMessage);
            Console.WriteLine(encrypt);
      
    }
  }
}