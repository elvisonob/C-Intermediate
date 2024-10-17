using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

string userInput;

List<string> todoList = new List<string>() { };

do
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    userInput = Console.ReadLine();



    // if an option that is not S, A, R, is selected, the user should be told that it is an incorrect choice

    switch (userInput)
    {
        case "S":
        case "s":
            Console.WriteLine("See all Todos");
            seeAllTodos();
            break;
        case "A":
        case "a":
            Console.WriteLine("Add a Todo");

            addATodo();
            break;
        case "R":
        case "r":
            Console.WriteLine("Remove a Todo");
            removeATodo();
            break;
        case "E":
        case "e":
            Console.WriteLine("Exit Loop");
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
    }
} while (userInput != "E");

//Writing a method for add a todo, it includes the userInput to the List array

void addATodo()
{
    //if case A is selected, the user Input should be collected afterwards and added to list
    var newInput = Console.ReadLine();
    todoList.Add(newInput);
}

void seeAllTodos()
{
    for (int i = 0; i < todoList.Count; ++i)
    {
        Console.WriteLine($"{i + 1}: " + todoList[i]);
    }
}


//void removeATodo()
//{


//    if (todoList.Count == 0)
//    {
//        Console.WriteLine("no todos have been added yet");
//    }
//    else
//    {
//        seeAllTodos();
//        Console.WriteLine("Select Todos to remove");

//    }

//    var indexNum = Console.ReadLine();

//    bool isNumber;
//    do
//    {
//        for (int i = 0; i < todoList.Count; ++i)
//        {
//            isNumber = int.TryParse(indexNum, out int number);
//            if (isNumber)
//            {
//                var newNumber = number - 1;

//                todoList.Remove(todoList[newNumber]);
//                Console.WriteLine("Todo Removed:" + todoList[newNumber]);


//            }
//            else
//            {
//                Console.WriteLine("It exceeds our range");
//            }


//        } 
//    } while (!isNumber);
//};


void removeATodo()
{
    // Declare the isNumber variable
    bool isNumber = false;

    if (todoList.Count == 0)
    {
        Console.WriteLine("No todos have been added yet");
        return;
    }

    seeAllTodos();  // Assuming this function shows all todo items
    Console.WriteLine("Select a Todo to remove (enter the number)");

    // Loop until a valid input is given
    do
    {
        var indexNum = Console.ReadLine();  // Read user input
        isNumber = int.TryParse(indexNum, out int number);  // Try to parse input as number

        if (isNumber)
        {
            // Check if the input number is within the valid range
            if (number >= 1 && number <= todoList.Count)
            {
                var newNumber = number - 1;  // Adjust for zero-based index

                // Store the todo before removing it, so you can display it
                var removedTodo = todoList[newNumber];

                todoList.RemoveAt(newNumber);  // Remove the item at the index
                Console.WriteLine("Todo Removed: " + removedTodo);
                break;  // Exit the loop after successful removal
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a valid number from the list.");
                isNumber = false;  // Force the loop to continue
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    } while (!isNumber);  // Loop until a valid number is entered
}

















