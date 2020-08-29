using System;

namespace csharp_stuff
{
    class MathStuff
    {
        static void Pattern(int[] args)
        {
            string message = "The pattern goes like this:";
            
            Console.WriteLine(message);
            for (int i = args[0]; i < args[1]; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main()
        {
            Console.WriteLine("Select starting number");
            string starting_num_str = Console.ReadLine();
            int starting_num_int = int.Parse(starting_num_str);

            Console.WriteLine("Select ending number");
            string ending_number_str = Console.ReadLine();
            int ending_number_int = int.Parse(ending_number_str);

            int[] args_list = {starting_num_int, ending_number_int};
            MathStuff.Pattern(args_list);
        }
    }
}