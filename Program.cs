using System;

namespace Deliverable_2___Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input numeric value between 1 and 100:

            Console.Write("Please enter a numeric value between 1 and 100: ");

            try
            {

                // Declare variables and Convert the string input variable into an integer
                string input = Console.ReadLine();
                int value;
                int count;
                value = int.Parse(input);
                // Console.ReadLine();


                //Space
                Console.WriteLine("\n");

                // If the value of user input is between 0 and 33, display value and loop number 1
                count = 1;
                if((value >= 0) && (value <= 33))
                {
                    Console.WriteLine("You have entered #: " + (value));
                    Console.WriteLine("This is the current value in  loop 1");
                    count = count - 1;

                //while statement
                    while (value > 0)
                    {
                        Console.WriteLine("The value of the iterative variable is: " + value.ToString());
                        value--;
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }


                // If the value of user input is between 34 and 66, display value and loop number 2
                else if ((value >= 34) && (value <= 66))
                {
                    Console.WriteLine("You have entered #: " + (value));
                    Console.WriteLine("This is the current value in  loop 2");
                    count = count - 1;

                    //while statement
                    while (value > 0)
                    {
                        Console.WriteLine("The value of the iterative variable is: " + value.ToString());
                        value--;
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);

                }


                // If the value of user input is between 67 and 100, display value and loop number 3
                else if ((value >= 67) && (value <= 100))
                {
                    Console.WriteLine("You have entered #: " + (value));
                    Console.WriteLine("This is the current value in  loop 3");
                    count = count - 1;

                    //while statement
                    while (value > 0)
                    {
                        Console.WriteLine("The value of the iterative variable is: " + value.ToString());
                        value--;
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }//end of while
                
                else
                    {
                    Console.WriteLine("An invalid numeric value was entered, please enter a value between 0 and 100");
                    Console.WriteLine("Hit any key to exit the program");

                    }

            }
            catch
            {
                Console.WriteLine("Please enter an integer value between 1 and 100 and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }//end of catch
        }//end of program
    }//end of program
}


         
