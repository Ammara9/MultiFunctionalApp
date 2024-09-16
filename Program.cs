namespace MultiFunctionalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true; // Variable to control whether the application is running
            int totalCost = 0; // Store the total cost of group tickets
            int numPeople = 0; // Store the number of people in the group
            int youth = 0; // Variable to count the number of youths
            int pensioner = 0; // Variable to count the number of pensioners
            int adult = 0; // Variable to count the number of adults

            while (running) // Loop until the user chooses to exit the application
            {
                // Display the main menu options to the user
                Console.WriteLine("*** Welcome to the Multi-Functional Console Application ***");
                Console.WriteLine("*** This Application offers a Main Menu with five options: ***");
                Console.WriteLine("1. To Accessing the local cinema price list");
                Console.WriteLine("2. To Calculating the price for an individual or a group");
                Console.WriteLine("3. To Writing a given text ten times");
                Console.WriteLine("4. To Splitting a string into individual words");
                Console.WriteLine("0. To Exiting the program");

                string input = Console.ReadLine(); // Read user input from the console

                switch (input) // Process the input based on the menu selection
                {
                    case "0": // Exit the program
                        running = false; // Set running to false to stop the loop
                        Console.WriteLine("Exiting..."); // Notify the user that the program is exiting
                        break;

                    case "1": // Option to display cinema prices based on age
                        Console.WriteLine("Enter the age to know the Price"); // Prompt the user to enter their age
                        if (int.TryParse(Console.ReadLine(), out int age)) // Try to parse the input as an integer
                        {
                            if (age > 5 && age <= 20) // If the user is 20 or younger, they are considered youth
                            {
                                Console.WriteLine($"Youth Price: 80kr."); // Display the youth price
                            }
                            else if (age > 20 && age <= 63) // If the user is 64 or older, they are considered a pensioner
                            {
                                Console.WriteLine($"Adult & Standard Price: 120kr"); // Display the pensioner price
                            }
                            else if (age >= 64 && age <= 100) // If the user is 64 or older, they are considered a pensioner
                            {
                                Console.WriteLine($"Pensioner price: SEK 90"); // Display the pensioner price
                            }
                            else if (age >= 0 && age < 5 || age > 100) // If the user is 64 or older, they are considered a pensioner
                            {
                                Console.WriteLine($"Free Entry."); // Display the pensioner price
                            }
                            else // If the user is between 21 and 63, they are considered an adult
                            {
                                Console.WriteLine($"Invalid age, please try again."); // Display the adult price
                            }
                        }
                        
                        break;

                    case "2": // Option to calculate the price for a group of people
                        Console.WriteLine("Enter the number of people in the group:"); // Ask the user for the group size
                        if (int.TryParse(Console.ReadLine(), out int groupSize)) // Parse the group size as an integer
                        {
                            if (groupSize < 0)
                            {
                                Console.WriteLine("Invalid input. Number of people cannot be negative. Please try again.");
                                continue; // Go back to the beginning of the switch statement
                            }
                            numPeople = groupSize; // Store the group size
                            totalCost = 0; // Reset total cost to 0
                            youth = 0; // Reset youth count to 0
                            pensioner = 0; // Reset pensioner count to 0
                            adult = 0; // Reset adult count to 0

                            // Loop through the number of people to calculate the price for each
                            for (int i = 0; i < groupSize; i++)
                            {
                                Console.WriteLine($"Enter the age of person {i + 1}:"); // Ask for the age of each person
                                if (int.TryParse(Console.ReadLine(), out int age1)) // Parse the age
                                {
                                    if (age1 < 0)
                                    {
                                        Console.WriteLine("Invalid input. Age cannot be negative. Please try again.");
                                        i--; // Decrement the loop counter to ask for the age again
                                        continue; // Skip to the next iteration of the loop
                                    }
                                    if (age1 > 5 && age1 <= 20) // If the person is a youth
                                    {
                                        totalCost += 80; // Add youth price to total cost
                                        youth++; // Increment the youth count
                                    }
                                    else if (age1 >= 64 && age1 <= 100) // If the person is a pensioner
                                    {
                                        totalCost += 90; // Add pensioner price to total cost
                                        pensioner++; // Increment the pensioner count
                                    }
                                    else if (age1 > 20 && age1 <= 63)// If the person is an adult
                                    {
                                        totalCost += 120; // Add adult price to total cost
                                        adult++; // Increment the adult count
                                    }
                                    else if (age1 >= 0 && age1 < 5 || age1 > 100)
                                    {
                                        totalCost += 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Input");
                                    }
                                }
                                
                            }
                            // Display the group pricing summary
                            Console.WriteLine($"Summary of Price: You have Number of youth: {youth}, Number of pensioner: {pensioner} & Number of adult: {adult}. ");
                            Console.WriteLine($"Total Number of peoples are: {numPeople}"); // Display total number of people
                            Console.WriteLine($"Total cost is: {totalCost}kr."); // Display the total cost
                        }
                       
                        break;

                    case "3": // Option to write a given text ten times
                        Console.WriteLine("Write Anything: "); // Ask the user to input a word or sentence
                        string word = Console.ReadLine(); // Read the user input

                        // Loop to write the text 10 times with spaces in between
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(word); // Output the word
                            if (i < 10) // Add a space after each word
                            {
                                Console.Write(" ");
                            }
                        }
                        break;

                    case "4": // Option to split a sentence into individual words
                        Console.WriteLine("Write a sentence at least three words:"); // Prompt user for a sentence
                        string inputSentence = Console.ReadLine(); // Read the input sentence
                        string[] sentences = inputSentence.Split(' '); // Split the sentence into words

                        // Output each word individually
                        Console.WriteLine("The individual words are:");
                        foreach (string sentence in sentences)
                        {
                            Console.WriteLine(sentence); // Print each word
                        }

                        // If the sentence has at least 3 words, display the third word
                        if (sentences.Length >= 3)
                        {
                            Console.WriteLine("The third word is: " + sentences[2]); // Output the third word
                        }
                        else
                        {
                            Console.WriteLine("The sentence does not have at least three words."); // Error for too few words
                        }
                        break;

                    default: // If the user selects an invalid option
                        Console.WriteLine("Invalid option, please try again."); // Notify of invalid option
                        break;
                }
            }
        }
    }
}
