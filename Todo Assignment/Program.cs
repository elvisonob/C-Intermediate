using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

string userInput;

List<string> todoList = new List<string>() { "Become a programming Genius", "Be the best dad ever" };

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

void addATodo(){
    //if case A is selected, the user Input should be collected afterwards and added to list
    var newInput = Console.ReadLine();
    todoList.Add(newInput);
}

void seeAllTodos()
{
    for (int i = 0; i < todoList.Count; ++i)
    {
        Console.WriteLine($"{i + 1}: " + todoList[i] );
    }
}

void removeATodo(){
    Console.WriteLine("Select the index of the todo you want to remove");
}
















