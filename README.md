# Multi-Functional Console Application

## Overview
This is a simple console application built in C# that provides several functionalities through a main menu interface. It allows users to:
1. Access cinema pricing based on age.
2. Calculate the ticket price for an individual or group.
3. Output a given text ten times.
4. Split a sentence into individual words and display the third word (if available).
5. Exit the application.

## Features
### 1. Cinema Price List
The user can input their age to receive a cinema price based on the following categories:
- Youth (20 years or younger): 80 kr
- Adult (21 to 63 years): 120 kr
- Pensioner (64 years or older): 90 kr

### 2. Group Price Calculation
The user can input the number of people in a group, along with the age of each individual. The program calculates and displays:
- Total number of youths, adults, and pensioners.
- Total cost of cinema tickets for the group.

### 3. Text Repetition
The user can input a string, and the program will output the string ten times, separated by spaces.

### 4. Sentence Splitter
The user can input a sentence with at least three words. The program splits the sentence into individual words and:
- Displays each word on a new line.
- Displays the third word, if the sentence contains at least three words.

### 5. Exit
The user can choose to exit the program at any time by selecting the `0` option in the main menu.

## How to Use
1. **Run the Program**: Start the application, and you'll be greeted with a menu offering five options.
2. **Select an Option**: Type the number corresponding to the feature you'd like to use and press Enter.
   - For example, type `1` to access the cinema price list or `2` to calculate group pricing.
3. **Follow Prompts**: Based on your choice, the program will prompt you for further input (age, number of people, etc.).
4. **Exit the Program**: Type `0` and press Enter to exit the program.

## Code Structure
- **Main Menu Loop**: The program runs in a loop controlled by a `bool running` flag. The loop continues until the user selects option `0` to exit.
- **Switch Case Logic**: Each menu option is handled by a `switch` statement. Based on the user's input, the program either:
  - Displays cinema prices.
  - Calculates group ticket prices.
  - Repeats a text.
  - Splits a sentence.
  - Exits the program.
  
## Sample Interaction
```
*** Welcome to the Multi-Functional Console Application ***
*** This Application offers a Main Menu with five options: ***
1. To Accessing the local cinema price list
2. To Calculating the price for an individual or a group
3. To Writing a given text ten times
4. To Splitting a string into individual words
0. To Exiting the program
```

### Example for Cinema Price List:
```
Enter the age to know the Price
> 18
Youth Price: 80kr.
```

### Example for Group Price Calculation:
```
Enter the number of people in the group:
> 3
Enter the age of person 1:
> 18
Enter the age of person 2:
> 65
Enter the age of person 3:
> 35
Summary of Price: You have Number of youth: 1, Number of pensioner: 1 & Number of adult: 1.
Total Number of peoples are: 3
Total cost is: 290kr.
```

### Example for Sentence Splitter:
```
Write a sentence at least three words:
> This is a test sentence.
The individual words are:
This
is
a
test
sentence
The third word is: a
```

## Dependencies
This application does not require any external libraries and runs directly in the console. You only need a .NET environment to compile and run the program.
