using System;

namespace Variables
{
    internal class Variable
    {
        public void run()
        {
            byte number = 2;
            Console.WriteLine(number);

            float floatNumber = 20.94f;
            Console.WriteLine(floatNumber);

            Char character = 'A';
            Console.WriteLine(character);

            string line = "Nabajyoti";
            Console.WriteLine(line);

            var n = 5;
            Console.WriteLine(n);

            String ax = "2";

            // parsing
            int x = Convert.ToInt32(ax);
            int y = int.Parse(ax);
            Console.WriteLine("{0}, {1}", x,y);

            bool v  = Convert.ToBoolean("true");
            Console.WriteLine(v);

            bool v2  = Convert.ToBoolean("gfg"); // wont work
            Console.WriteLine(v2);

        }
    }
}
