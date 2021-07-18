using System;

namespace MaskInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a secret");
            var userInput = Console.ReadLine();

            Console.WriteLine("Your secret was...");
            string secret;
            if (userInput.Length > 4)
            {
              secret = userInput.Substring(userInput.Length - 4).PadLeft(userInput.Length, '*');
              
            }
            else
            {
                secret = "That's not a very long secret.";
            }
            Console.WriteLine(secret);
        }
    }
}
