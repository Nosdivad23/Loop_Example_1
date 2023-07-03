namespace Loop_Example_1
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer positive number");
            Boolean done = false;

            while(!done)  // !done = true
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("The entry is: " + input);

                    // For Loop
                    Console.WriteLine("List of even numbers ");
                    for (int i = 0; i < input; i++)
                    {
                        int even = 2 * i;
                        Console.WriteLine(even + " is an even number");
                    }

                    // do while loop
                    Console.WriteLine(" ");
                    Console.WriteLine("List of odd numbers ");
                    int odd = 1;
                    int counter = 0;
                    do
                    {
                        Console.WriteLine(odd + " is an odd number");
                        odd = odd + 2;
                        counter++;

                    }

                    while (counter < input);
                   
                    done = true;


                }
                catch
                {
                    Console.WriteLine("Enter an integer positive number");
                }
            }   
        }
    }
}