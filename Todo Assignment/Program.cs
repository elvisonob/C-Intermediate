// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do");
Console.WriteLine("[S]ee all TODOS" );
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");


string userType = Console.ReadLine();
List<string> todos = new List<string>();

do
{
    

    if (userType == "Aa" || userType == "a")
    {
        Console.WriteLine("what do you want to add");
        var addTodos = Console.ReadLine();
        
    }

     if (userType == "S" || userType == "s")
    {

        foreach (var i in todos)
        {
            Console.WriteLine(i);
        }

    }

     if (userType == "R" || userType == "r")
    {
        //remove a unique todos
        foreach (var i in todos)
        {
            todos.Remove(i);
        }

    }
} while (userType != "E" || userType != "e");




