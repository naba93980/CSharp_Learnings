using System;

namespace HelloWorld
{
    internal class Program1
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            checked
            {
                byte n = 255;
                byte m = 255;

                // overflow checking happens here
                try
                {
                    m = (byte)(m + 1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                // unchecked keyword makes sure not to do overflow checking
                n = unchecked((byte)(n + 1));
                Console.WriteLine(n);
            }
        }
    }
}
