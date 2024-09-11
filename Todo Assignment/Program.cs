// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Tracing;

Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do");
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");


var userType = Console.ReadLine();

List<string> words = new List<string>();

switch (userType)
{
    case "S":
    case "s":
        seeAllTodos();
        break;

    case "A":
    case "a":
            Console.WriteLine("Add a todo");
        break;
    case "R":
    case "r":
            Console.WriteLine("Remove a todo");
        break;
    default:
        Console.WriteLine("invalid choice");
        break;
};

Console.ReadKey();


void seeAllTodos()
{
    if (words.Count == 0)
    {
        Console.WriteLine("No todo has been added yet");
    }
    else
        foreach (var word in words)
    {
        
        {
            Console.WriteLine(word);
        }
        
    }

}















