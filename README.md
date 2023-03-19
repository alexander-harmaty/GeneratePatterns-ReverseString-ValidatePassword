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

![option1code](images/carbon(1a).png)

This case prompts the user to enter a character and an integer for the size of the triangle. It then uses nested for loops to print a triangle of the given character to the given size. The outer loop controls the number of lines to print and the inner loops control the spaces and the character to print on each line.

Output:
![option1output](images/carbon(1).png)

### Option 2

![option2code](images/carbon(2a).png)

This case prompts the user to enter a character and an integer for the half-point size of the diamond. It then uses nested for loops to print a diamond of the given character to the given size. The first half of the diamond is printed using the same logic as in Case 1, and then the second half of the diamond is printed using a similar nested loop with decreasing spaces and increasing characters.

Output:
![option2output](images/carbon(2).png)

### Option 3

![option3code](images/carbon(3a).png) 

This case prompts the user to enter a number and then uses a while loop to reverse the entered number and store it in a string variable. The program then outputs the entered number followed by its reverse to the console.

Output:
![option3output](images/carbon(3).png) 

### Option 4

![option4](images/carbon(4).png)

This case prompts the user to enter a password and then checks if the password meets certain requirements (length between 6 and 15 characters, at least one uppercase letter, at least one lowercase letter, at least one digit, and at least one special character). The program uses a for loop to iterate through each character in the password string and sets boolean variables accordingly. If the password meets all the requirements, the program outputs a message saying the entered password is valid. If not, the program outputs a message with the reasons why the password is not valid.

### Option 5

This case simply outputs my thoughts on the lab as requested by the professor. These include how appropriate it was for a first lab and what I learned from it.

### Option 6

This case simply outputs a message indicating that the program will end and sets the loop variable to false, which will cause the program to exit the while loop and terminate.
