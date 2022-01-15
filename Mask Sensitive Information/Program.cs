using System;

namespace Mask_Sensitive_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a secret...");

            var secret = Console.ReadLine();

            if (secret.Length > 4)
            {
                Console.WriteLine(
                    string.Concat(
                        "".PadLeft(12, '*'),
                        secret.Substring(secret.Length - 4)
                        )
                    );
            }
            else
            {
                Console.WriteLine("Please tell me a longer secret!");
            }
        }
    }
}
