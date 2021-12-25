using System;

namespace WhyCompiledLangs
{
    class Looping
    {
        public static void Main()
        {
            long sum = 0;
            for(int i= 0; i <= 1000000000; i++)
                sum += i;

            Console.WriteLine(sum);
        }
    }
}
