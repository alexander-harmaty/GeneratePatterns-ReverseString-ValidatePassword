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
                        //UX Instructions
                        Console.WriteLine("User has selected (1)!\n");
                        Console.WriteLine("----------------------\n" +
                            "To display the triangle, the user must:\n" +
                            "\tenter a character to form the triangle with,\n" +
                            "\tAND\n" +
                            "\tenter an integer for the size of the triangle...\n");

                        //Input
                        Console.WriteLine("Please type a character, then press 'enter' to select your choice...");
                        char character1 = Console.ReadLine()[0];
                        
                        Console.WriteLine("Please type an integer, then press 'enter' to select your choice...");
                        int numOfLines1 = int.Parse(Console.ReadLine());

                        //Output
                        Console.WriteLine("----------------------\nResults:\n\n");

                        int count1 = numOfLines1 - 1;

                        for (int i = 1; i <= numOfLines1; i++)
                        {
                            for (int j = 1; j <= count1; j++)
                                Console.Write(" ");

                            count1--;

                            for (int j = 1; j <= 2 * i - 1; j++)
                                Console.Write(character1);

                            Console.WriteLine();
                        }
                        Console.WriteLine("");

                        break;

                    case 2:
                        //UX Instructions
                        Console.WriteLine("User has selected (2)!\n");
                        Console.WriteLine("----------------------\n" +
                            "To display the diamond, the user must:\n" +
                            "\tenter a character to form the diamond with,\n" +
                            "\tAND\n" +
                            "\tenter an integer for the half-point size of the diamond...\n");

                        //Input
                        Console.WriteLine("Please type a character, then press 'enter' to select your choice...");
                        char character2 = Console.ReadLine()[0];
                        
                        Console.WriteLine("Please type an integer, then press 'enter' to select your choice...");
                        int numOfLines2 = int.Parse(Console.ReadLine());

                        //Output
                        Console.WriteLine("----------------------\nResults:\n\n");

                        int count2;

                        count2 = numOfLines2 - 1;
                        
                        for (int i = 1; i<= numOfLines2; i++)
                        {
                            for (int j = 1; j <= count2; j++)
                                Console.Write(" ");

                            count2--;

                            for (int j = 1; j <= 2 * i - 1; j++)
                                Console.Write(character2);

                            Console.WriteLine();
                        }
                        
                        count2 = 1;
                        for (int i = 1; i<= numOfLines2; i++)
                        {
                            for (int j = 1; j<= count2; j++)
                                Console.Write(" ");

                            count2++;

                            for (int j = 1; j <= 2 * (numOfLines2 - i) - 1; j++)
                                Console.Write(character2);

                            Console.WriteLine();
                        }

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

