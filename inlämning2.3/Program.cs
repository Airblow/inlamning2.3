using System;
namespace inlämning2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, hur många kilometer planerar du att köra?");
            string kmt = Console.ReadLine();
            short kmn = short.Parse(kmt);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Och hur många dagar planerar du att hyra bilen?");
            string dagt = Console.ReadLine();
            short dagn = short.Parse(dagt);
            Console.WriteLine("--------------------------------------------");

            int totpris = 300 + kmn * 1 + (dagn - 1) * 500;
            Console.WriteLine("Kostnaden att hyra bilen kommer då att bli " + totpris + " kr");
            Console.ReadKey();

        }

    }

}
