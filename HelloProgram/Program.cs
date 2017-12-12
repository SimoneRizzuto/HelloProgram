using System;

namespace HelloProgram
{
    class Program
    {
        static int foo = 5;
        static void Main(string[] args)
        {
            if (foo == 5)
            {
                Console.WriteLine("Foo is five. :D");
            }
            else
            {
                Console.WriteLine("Foo is not five. :<");
            }
            for (int i = 0; i < 5; i++)
            {
                foo++;
            }

            Console.WriteLine("Foo is now equal to {0}.", foo);
            
            while (foo > 0)
            {
                foo--;
                Console.WriteLine(foo);
            }

            Console.WriteLine("Done!");

            switch (foo)
            {
                case 0:
                    Console.WriteLine("NANI!?");
                    break;

                case 1:
                    Console.WriteLine("BEGONE THOT!");
                    break;

                case 2:
                    Console.WriteLine("Nya~");
                    break;

                case 3:
                    Console.WriteLine("some other anime meme idfk");
                    break;

                default:
                    Console.WriteLine("This is here just in case we got an unexpected input");
                    break;
            }
        }
    }
}
