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
                            "\tenter an integer for the size of the triangle.\n");

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
                            "\tenter an integer for the half-point size of the diamond.\n");

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
                        //UX Instructions
                        Console.WriteLine("User has selected (3)!\n");
                        Console.WriteLine("----------------------\n" +
                            "To display the mirrored number, the user must enter a string of numbers for the program to reflect.\n" +
                            "For example, if the user entered '123' , the program will display '123321'\n");

                        //Input
                        Console.WriteLine("Please type an integer, then press 'enter' to select your choice... ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        //Output
                        string mirror = "" + num;

                        while (num > 0)
                        {
                            mirror += (num % 10);
                            num /= 10;
                        }

                        Console.WriteLine("----------------------\nResults:\n\n" + mirror);

                        break;

                    case 4:
                        //UX Instructions
                        Console.WriteLine("User has selected (4)!\n");
                        Console.WriteLine("----------------------\n" +
                            "For a password to be validated, it must meet ALL of the following requirements:\n" +
                            "\tPassword length must be between 6 and 15 characters,\n" +
                            "\tPassword must contain at lease one uppercase letter (A-Z),\n" +
                            "\tPassword must contain at least one lowercase letter (a-z),\n" +
                            "\tPassword must contain at least one digit (0-9),\n" +
                            "\tPassword must contain at least one of the following speacial characters:\n" +
                            "\t\t! @ # S % ^ & * ( ) + = _ - { } [ ] : ; \" ' ? < > , .\n");

                        //Input
                        Console.WriteLine("Please type a password, then press 'enter' to test the passwrod...");
                        string password = Console.ReadLine();

                        //Output
                        Console.WriteLine("\n---------------\nResults:\n");

                        int uppers = 0, lowers = 0, digits = 0, specials = 0;

                        for (int i = 0; i < password.Length; i++)
                        {
                            if (Char.IsUpper(password[i]))
                                uppers++;
                            if (Char.IsLower(password[i]))
                                lowers++;
                            if (Char.IsDigit(password[i]))
                                digits++;
                            if ("!@#$%^&*()+=_-{}[]:;\"'?<>,.".Contains("" + password[i]))
                                specials++;
                        }

                        bool valid = true;

                        if (password.Length < 6 || password.Length > 15)
                        {
                            Console.WriteLine("Entered password length is not between 6 & 15!");
                            valid = false;
                        }
                        if (uppers == 0)
                        {
                            Console.WriteLine("Entered password does not contain an uppercase letter!");
                            valid = false;
                        }
                        if (lowers == 0)
                        {
                            Console.WriteLine("Entered password does not contain a lowercase letter!");
                            valid = false;
                        }
                        if (digits == 0)
                        {
                            Console.WriteLine("Entered password does not contain a digit!");
                            valid = false;
                        }
                        if (specials == 0)
                        {
                            Console.WriteLine("Entered password does not contain a special character!");
                            valid = false;
                        }
                        if (valid)
                            Console.WriteLine("Entered password is valid!\n");
                        else
                            Console.WriteLine("Entered password is NOT valid!\n");
                        
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

