using System;

namespace HelloWorld
{
    public class RandomDemo
    {
        public static void runRandom()
        {

            // methods on instance of Random class
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(4, 7));
            Console.WriteLine(random.NextSingle());


            // randomly generates a character array & uses it to create password string
            int passwordLength=10;
            char[] buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 20));
            }
            var password = new String(buffer);
            Console.WriteLine(password);
        }
    }
}
