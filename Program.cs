using System;

namespace Lab1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Lab 1 Assignment by Alexander Harmaty");
            Console.WriteLine("02/06/2022\n");

            bool loop = true;
            while(loop)
            {
                Console.WriteLine("" +
                    "--------------------------------------------------------------------------------------------\n" +
                    "MENU\n" +
                    "----\n" +
                    "(1) Enter a character & number. Display a triangle of the given character to the given size.\n" +
                    "(2) Enter a character & number. Display a diamond of the given character to the given size.\n" +
                    "(3) Enter a string of numbers.  Display the entered number followed by its reverse.\n" +
                    "(4) Enter a password string.    Validate if string follows password character requirements.\n" +
                    "(5) Thoughts about Lab 1.\n" +
                    "(6) Exit Program!\n" +
                    "-----------------\n");

                Console.WriteLine("Please type an integer, then press 'enter' to select your choice...");

                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("User has selected (1)!\n");
                        Console.WriteLine("----------------------\n" +
                            "To display the triangle, the user must:\n" +
                            "\tenter a character to form the triangle,\n" +
                            "\tAND\n" +
                            "\tenter an integer for the size of the triangle...\n");

                        Console.WriteLine("Please type a character, then press 'enter' to select your choice...");
                        char character = Console.ReadLine()[0];

                        Console.WriteLine("Please type an integer, then press 'enter' to select your choice...");
                        int numOfLines = int.Parse(Console.ReadLine());
                        
                        //Output pattern
                        int i, j;
                        int count = numOfLines - 1;
                        for (i = 1; i <= numOfLines; i++)
                        {
                            for (j = 1; j <= count; j++)
                                Console.Write(" ");

                            count--;

                            for (j = 1; j <= 2 * i - 1; j++)
                                Console.Write(character);

                            Console.WriteLine();
                        }

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        Console.WriteLine("User has selected (6)!\nEnd Of Program.");
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        loop = false;

                        break;
                }
            }
        }
    }
}

