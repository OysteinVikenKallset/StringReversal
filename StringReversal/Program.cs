// Initialize a counter for the number of attempts
int i = 0;

// Initialize a string to hold the user's input
String userInput = "";

// Initialize a boolean flag to indicate whether the user's input is valid
bool isValidInput = false;

// Prompt the user to enter a string
Console.WriteLine("Skriv inn en tekst");

// Keep asking for input until valid input is received or the maximum number of attempts is reached
while (!isValidInput)
{
    // Read the next line of input from the user, or use an empty string if no input is provided
    userInput = Console.ReadLine() ?? String.Empty;

    // Check if the input is not null, not empty, and not just white-space characters
    isValidInput = !String.IsNullOrWhiteSpace(userInput);

    // If the input is not valid...
    if (!isValidInput)
    {
        // Inform the user that they must enter a string
        Console.WriteLine("Du må skrive inn en tekst");

        // Increment the counter for the number of attempts
        i++;

        // If the maximum number of attempts has been reached...
        if (i >= 4)
        {
            // Inform the user that they have used too many attempts
            Console.WriteLine("Du har brukt for mange forsøk");

            // Break out of the loop
            break;
        }
    }
}

// If valid input was received...
if (isValidInput)
{
    // Reverse the input and display it to the user
    Console.WriteLine($"Dette er teksten reversert: {Reverse(userInput)}");
}

// Define a method to reverse a string
static string Reverse(string input)
{
    // Convert the string to an array of characters
    char[] charArray = input.ToCharArray();

    // Reverse the order of the characters in the array
    Array.Reverse(charArray);

    // Convert the array of characters back into a string and return it
    return new string(charArray);
}