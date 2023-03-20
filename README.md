# Generate Patterns, Reverse Strings, Validate Passwords

(FSC-BCS-426-Lab1)

## Output Menu

![Menu](images/carbon.png)

## Assignment Context

This project was one of the first assignments for my C# programming class.

The goal of this assignment was for students to get an introduction to C# and ASP.NET, so we were prompted to add four specific features exploring strings and patterns. 

We were expected to be able to generate two different patterns based on user input, reverse a string provided by the user, and validate a given password to assure it meets the requirements.

This was a solo assignment made with C# and ASP.NET using Visual Studio 2022.


## Features

The program includes five options: 
* (1) to display a triangle of a given character and size, 
* (2) to display a diamond of a given character and size, 
* (3) to display a mirrored number, 
* (4) to validate a password, and 
* (5) to provide comments about the lab. 


## How It Works

My program allows the user to select from a menu of options to perform the various tasks. 

It begins by printing out the name of the assignment and the current date.

Then, the program enters a loop that displays a menu of options and prompts the user to select an option by entering an integer. 

The program then uses a switch statement to perform the selected task.

The program ends when the user selects the option to exit.


### Option 1

This case prompts the user to enter a character and an integer for the size of the triangle. It then uses nested for loops to print a triangle of the given character to the given size. The outer loop controls the number of lines to print and the inner loops control the spaces and the character to print on each line. The program accomplishes this by first printing a line with spaces and a single instance of the given character, then progressively increasing the number of characters on each subsequent line while decreasing the number of spaces.

Output:
![option1output](images/carbon(1).png)

### Option 2

This case prompts the user to enter a character and an integer for the half-point size of the diamond. It then uses nested for loops to print a diamond of the given character to the given size. The first half of the diamond is printed using the same logic as in Case 1, and then the second half of the diamond is printed using a similar nested loop with decreasing spaces and increasing characters.

Output:
![option2output](images/carbon(2).png)

### Option 3

This case prompts the user to enter a string of numbers, which is converted to an integer using Convert.ToInt32(). The program then uses a while loop to reverse the entered number by repeatedly getting the remainder of the number divided by 10 and adding it to the end of a string variable. The number is then divided by 10 to remove the last digit and the process is repeated until the number is reduced to 0. Finally, the program outputs the entered number followed by its reverse to the console.

Output:
![option3output](images/carbon(3).png) 

### Option 4

This case prompts the user to enter a password and then checks if the password meets certain requirements (length between 6 and 15 characters, at least one uppercase letter, at least one lowercase letter, at least one digit, and at least one special character). The program uses a for loop to iterate through each character in the password string and sets boolean variables accordingly. If the password meets all the requirements, the program outputs a message saying the entered password is valid. If not, the program outputs a message with the reasons why the password is not valid.

Output:
![option4](images/carbon(4).png)

### Option 5

This case simply outputs my thoughts on the lab as requested by the professor. These include how appropriate it was for a first lab and what I learned from it.

### Option 6

This case simply outputs a message indicating that the program will end and sets the loop variable to false, which will cause the program to exit the while loop and terminate.
