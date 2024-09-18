// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Tracing;

bool shallExit = false;
List<string> words = new List<string>();
while (!shallExit)
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do");
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userType = Console.ReadLine();

    switch (userType)
    {
        case "S":
        case "s":
            seeAllTodos();
            break;

        case "A":
        case "a":
            Console.WriteLine("Add a todo");
            addATodo();
            break;
        case "R":
        case "r":
            Console.WriteLine("Remove a todo");
            removeTodo();
            break;
        case "E":
        case "e":
            shallExit = true;
            break;
        default:
            Console.WriteLine("invalid choice");
            break;
    };
}


    void seeAllTodos()
    {
        if (words.Count == 0)
        {
            Console.WriteLine("No todo has been added yet");
        }
        else
            for (var i =0; i<words.Count; ++i)
            {

                {
                Console.WriteLine($"{i + 1}. {words[i]}");
                }

            }

    }

    void addATodo()
    {
        ///add a userInput to the array list
        bool isValid = false;

        while (!isValid)
        {
            Console.WriteLine("Enter a description");
            var description = Console.ReadLine();

            if (description == "")
            {
                Console.WriteLine("Please enter a valid description");
            }
            else if (words.Contains(description))
            {
                Console.WriteLine("Todo must be unique");
            }
            else
            {
                isValid = true;
                words.Add(description);
            }
        }
    };

void removeTodo()
{
    // select index of todo to remove and remove it
    for (var i = 0; i < words.Count; ++i)
    {

        var userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.WriteLine("Please enter a vaild index");
            continue;
        }

        if (int.TryParse(userInput, out int index) && index>=1 && index <=words.Count)
        {

            words.RemoveAt(index - 1);
            Console.WriteLine("Todo removed");
        }
        

    }
}















