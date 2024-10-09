using System.ComponentModel.Design;



//check the user input and return true if it is a number and return false when not a number

// ask the user to keep writing a number until they give a valid input

// so, if number is negative, user should keep making inputs until there is a positive.

bool isParsingSuccessful;
do
{
    Console.WriteLine("Enter a number:");
    var userInput = Console.ReadLine();
    isParsingSuccessful = int.TryParse(userInput, out int number);

    if (isParsingSuccessful)
    {
        Console.WriteLine("Number is valid " + number);
    }
    else
    {
        Console.WriteLine("Number is not valid");
    }


} while (!isParsingSuccessful);




Console.ReadKey();





